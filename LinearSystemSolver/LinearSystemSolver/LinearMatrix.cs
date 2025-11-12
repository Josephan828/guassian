namespace LinearSystemSolver
{
    class LinearMatrix
    {
        private double[,] _matrix;
        private int rows;
        private int cols;
        private int count;
        private int timeOut;


        public event Action<string> OnStepCompleted;

        private LinearMatrix(double[,] matrix)
        {
            if (matrix is null)
                throw new ArgumentNullException(nameof(matrix));

            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            count = rows * cols;

            _matrix = new double[rows, cols];

            Array.Copy(matrix, _matrix, count);
        }

        public static LinearMatrix Create(double[,] matrix)
        {
            return new LinearMatrix(matrix);
        }

        // Iterative solution
        private async Task ToRowEchelon()
        {
            int leadingCol = 0;

            for (int r = 0; r < rows && leadingCol < cols;)
            {
                // Try to find a row can contain a leading  
                int leadingRow = -1;
                for (int rr = r; rr < rows; rr++)
                {
                    if (_matrix[rr, leadingCol] != 0)
                    {
                        leadingRow = rr;
                        break;
                    }
                }

                if (leadingRow == -1)
                {
                    await Task.Delay(timeOut);
                    OnStepCompleted?.Invoke($"Column {leadingCol + 1} can not contain a leading element\r\n");
                    leadingCol++;   
                    continue;
                }

                if (leadingRow != r)
                {
                    SwapRows(r, leadingRow);
                    await Task.Delay(timeOut);
                    OnStepCompleted?.Invoke($"Swapping R{r + 1} with R{leadingRow + 1}\r\n");
                }


                // Normalize leading row to get leading  = 1
                if (_matrix[r, leadingCol] != 1)
                {

                    double leadingValue = 1 / _matrix[r, leadingCol];

                    for (int cc = leadingCol; cc < cols; cc++)
                    {
                        _matrix[r, cc] *= leadingValue;
                    }

                    await Task.Delay(timeOut);
                    OnStepCompleted?.Invoke($"Normalizing R{r + 1}\r\n");
                    OnStepCompleted?.Invoke($"R{r + 1} = R{r + 1} * {leadingValue:0.##}\r\n\n");
                }
                // leading is ok


                if(r + 1 >= rows) 
                    break;

                await Task.Delay(timeOut);
                OnStepCompleted?.Invoke("Converting elements under the leading to zero\r\n");
                // Convert all elements below the leading to zero
                for (int rr = r + 1; rr < rows; rr++)
                {
                    double factor = _matrix[rr, leadingCol];

                    if (factor == 0) continue;

                    for (int cc = leadingCol; cc < cols; cc++)
                    {
                        _matrix[rr, cc] -= factor * _matrix[r, cc];
                    }

                    await Task.Delay(timeOut);
                    OnStepCompleted?.Invoke($"R{rr + 1} = R{rr + 1} - {factor:0.##}R{r + 1}\r\n");
                }   

                r++;
                leadingCol++;

                OnStepCompleted?.Invoke("==============\r\n");
            }

            await Task.Delay(timeOut);
            OnStepCompleted?.Invoke("\nMatrix has been converted to REF\r\n");
        }

        public async Task ToReducedRowEchelon()
        {
            if(!IsRowEchelon())
                await ToRowEchelon();

            await Task.Delay(timeOut);
            OnStepCompleted?.Invoke("==============\r\n");
            OnStepCompleted?.Invoke("Converting to RREF\r\n");

            for (int r = 1; r < rows; r++)
            {
                int leadingCol = -1;

                for (int c = 0; c < cols; c++)
                {
                    if (_matrix[r, c] == 1)
                    {
                        leadingCol = c;
                        break;
                    }
                }

                if (leadingCol == -1)
                {
                    OnStepCompleted?.Invoke($"There is no leading element at R{r + 1}\r\n");
                    continue;
                }

                for (int rr = r - 1; rr >= 0; rr--)
                {
                    double factor = _matrix[rr, leadingCol];

                    for (int c = leadingCol; c < cols; c++)
                    {
                        _matrix[rr, c] -= factor * _matrix[r, c];
                    }

                    await Task.Delay(timeOut);
                    OnStepCompleted?.Invoke($"R{rr + 1} = R{rr + 1} - {factor:0.##}R{r + 1}\r\n");
                }   
            }
        }

        private bool IsRowEchelon()
        {
            int lastLeading = -1;

            for (int r = 0; r < rows; r++)
            {
                int leadingCol = -1;

                for (int c = 0; c < cols; c++)
                {
                    if (_matrix[r, c] != 0)
                    {
                        leadingCol = c;
                        break;
                    }
                }

                if (leadingCol == -1) // zero row
                {
                    for (int rr = r + 1; rr < rows; rr++)
                    {
                        for (int cc = 0; cc < cols; cc++)
                        {
                            if (_matrix[rr, cc] != 0)
                            {
                                return false; // Non-zero row comes after zero row
                            }
                        }
                    }

                    // if you are here all the next rows are zero rows .
                    // So , no need to check any other thing
                    return true;
                }

                // Ensure that the leading is one
                if (_matrix[r, leadingCol] != 1)
                    return false;

                // Ensure that the current leading element
                // is positioned at the right of the leading element at the above row
                if (leadingCol <= lastLeading)
                    return false;

                lastLeading = leadingCol;
            }

            return true;
        }

        private bool IsReducedRowEchelon()
        {
            if (!IsRowEchelon())
                return false;

            for (int r = 0; r < rows; r++)
            {
                int leadingCol = -1;

                for (int c = 0; c < cols; c++)
                {
                    if (_matrix[r, c] == 1)
                    {
                        leadingCol = c;
                        break;
                    }
                }

                if (leadingCol == -1)
                    continue;

                for (int rr = r - 1; rr >= 0; rr--)
                {
                    if (_matrix[rr, leadingCol] != 0)
                        return false;
                }
            }

            return true;
        }

        private void SwapRows(int row1, int row2)
        {
            for (int c = 0; c < cols; c++)
            {
                // swap using tuble deconstruction
                (_matrix[row1, c], _matrix[row2, c]) = (_matrix[row2, c], _matrix[row1, c]);
            }
        }

        public async Task SolveWithSteps(bool fastMood)
        {
            timeOut = fastMood ? 0 : 300;

            OnStepCompleted?.Invoke("Solution Process started\r\n");

            if (!IsReducedRowEchelon())
            {
                await ToReducedRowEchelon();
                OnStepCompleted?.Invoke("\nMatrix has been converted to RREF\r\n");
            }
           
            await FireResult();
        }

        private async Task FireResult()
        {
            OnStepCompleted?.Invoke("\n==============\r\n");

            bool hasSolution = true;

            for (int r = 0; r < rows; r++)
            {
                bool allZero = true;
                for (int c = 0; c < cols - 1; c++)
                {
                    if (_matrix[r, c] != 0)
                    {
                        allZero = false;
                        break;
                    }
                }

                if (allZero && _matrix[r, cols - 1] != 0)
                {
                    MessageBox.Show("Inconsistent system detected.\nNo solution exists.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OnStepCompleted?.Invoke("Inconsistent system detected.\r\n");
                    OnStepCompleted?.Invoke("No solution exists.\r\n");
                    hasSolution = false;
                    break;
                }

                if (allZero && _matrix[r, cols - 1] == 0)
                {
                    MessageBox.Show("Infinite solutions", "Solution Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnStepCompleted?.Invoke("Infinite solutions\r\n");
                    return;
                }
            }

            if (hasSolution)
            {
                for (int r = 0; r < rows; r++)
                {
                    OnStepCompleted?.Invoke($"X{r + 1} : {_matrix[r, cols - 1]:0.##}\r\n");
                    await Task.Delay(timeOut);
                }

                OnStepCompleted?.Invoke("\n==============\r\n");
            }

            var form = new PreviewForm(_matrix);
            form.Show();
        }
    }
}

