using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Matrix
    {
        public double[,] matrix;
        public int size { get; set; }

        public Matrix(int size, double[,] matrix)
        {
            this.size = size;
            this.matrix = matrix;
        }

        public double[,] GetMatrix()
        {
            return matrix;
        }

        public int GetSize()
        {
            return size;
        }

        public static Matrix ReadMatrix(System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2)
        {
            int size;

            size = Convert.ToInt32(textBox1.Text);
            double[,] matrix = new double[size, size];

            string input = textBox2.Text;
            string[] rows = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < size; i++)
            {
                string[] elements = rows[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(elements[j]);
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Math.Round(matrix[i, j], 5);
                }
            }

            Matrix res = new Matrix(size, matrix);
            return res;
        }
    }
}
