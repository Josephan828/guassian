using System;

namespace MatrixInversion
{
    public struct Matrix
    {
        private int rows;
        private int cols;
        private double[,] _matrix;

        public int Rows => rows;
        public int Cols => cols;

        public static Matrix FromArray(double[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            Matrix matrix = new Matrix(rows, cols);
            Array.Copy(array, matrix._matrix, array.Length);
            return matrix;
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            _matrix = new double[rows, cols];
        }

        public Matrix(Matrix matrix) // copy constructor
        {
            rows = matrix.rows;
            cols = matrix.cols;
            _matrix = new double[rows, cols];
            Array.Copy(matrix._matrix, _matrix, matrix._matrix.Length);
        }

        public double this[int row, int col]
        {
            get => _matrix[row, col];
            set => _matrix[row, col] = value;
        }

        public static Matrix operator *(Matrix matrix, double scalar)
        {
            Matrix result = new Matrix(matrix.rows, matrix.cols);

            for (int r = 0; r < matrix.rows; r++)
                for (int c = 0; c < matrix.cols; c++)
                    result[r, c] = matrix[r, c] * scalar;

            return result;
        }

        public static Matrix operator *(double scalar, Matrix matrix)
        {
            return matrix * scalar;
        }

        public Matrix GetInverse()
        {
            double det = GetDeterminant();

            if (Math.Abs(det) < 1e-9) // if determinant is zero
                throw new InvalidOperationException("Matrix is singular and cannot be inverted.");

            Matrix adj = GetAdjoint();
            return (1.0 / det) * adj;
        }

        public Matrix GetAdjoint()
        {
            return GetCofactor().GetTranspose();
        }

        public Matrix GetTranspose()
        {
            Matrix t = new Matrix(cols, rows);

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    t[c, r] = _matrix[r, c];

            return t;
        }

        public double GetDeterminant()
        {
            if (rows != cols)
                throw new InvalidOperationException("Determinant requires a square matrix.");

            Matrix temp = new Matrix(this);
            return temp.GetDeterminantInternal();
        }

        private double GetDeterminantInternal()
        {
            if (rows == 1)
                return _matrix[0, 0];

            if (rows == 2)
                return _matrix[0, 0] * _matrix[1, 1]
                     - _matrix[0, 1] * _matrix[1, 0];

            double det = 1;
            int pivotCol = 0;

            for (int r = 0; r < rows; r++)
            {
                int pivotRow = -1;

                for (int rr = r; rr < rows; rr++)
                {
                    if (Math.Abs(_matrix[rr, pivotCol]) > 1e-9)
                    {
                        pivotRow = rr;
                        break;
                    }
                }

                if (pivotRow == -1)
                    return 0;

                if (pivotRow != r)
                {
                    SwapRows(r, pivotRow);
                    det *= -1;
                }

                for (int rr = r + 1; rr < rows; rr++)
                {
                    double factor = _matrix[rr, pivotCol] / _matrix[r, pivotCol];
                    for (int c = pivotCol; c < cols; c++)
                        _matrix[rr, c] -= factor * _matrix[r, c];
                }

                det *= _matrix[r, pivotCol];
                pivotCol++;
            }

            return det;
        }

        public Matrix GetCofactor()
        {
            Matrix cof = new Matrix(rows, cols);

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    cof[r, c] = Math.Pow(-1, r + c) * GetMinor(r, c);

            return cof;
        }

        public double GetMinor(int rowIndex, int colIndex)
        {
            Matrix m = new Matrix(rows - 1, cols - 1);

            for (int r = 0, i = 0; r < rows; r++)
            {
                if (r == rowIndex) continue;

                for (int c = 0, j = 0; c < cols; c++)
                {
                    if (c == colIndex) continue;

                    m[i, j] = _matrix[r, c];
                    j++;
                }
                i++;
            }

            return m.GetDeterminant();
        }

        private void SwapRows(int r1, int r2)
        {
            for (int c = 0; c < cols; c++)
                (_matrix[r1, c], _matrix[r2, c]) = (_matrix[r2, c], _matrix[r1, c]);
        }
    }
}
