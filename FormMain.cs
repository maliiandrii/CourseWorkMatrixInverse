using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonSchultz_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (!ValidateMatrixSize())
            {
                MessageBox.Show("Некоректний ввід розміру матриці.\nРозмір матриці повинен бути цілим числом в діапазоні від 2 до 10.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateMatrixContent())
            {
                MessageBox.Show("Некоректний ввід елементів матриці.\nЕлементи матриці мають бути дійсними числами від -100 до 100 та їх кількість має відповідати розмірності.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Matrix matrixMain = Matrix.ReadMatrix(textBoxSize,textBoxMatrix);
            SchultzInverse matrix = new SchultzInverse(matrixMain.size, matrixMain.matrix);
            double det = Determinant(matrix);

            if (det != 0)
            {
                labelSchultz.Text = WriteMatrix(matrix.Inverse());
                labelCompSch.Text = matrix.comparisons.ToString();
            }
            else
            {
                MessageBox.Show("Визначник матриці рівний нулю. Обертання матриці обчислити не можливо!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLUP_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (!ValidateMatrixSize())
            {
                MessageBox.Show("Некоректний ввід розміру матриці.\nРозмір матриці повинен бути цілим числом в діапазоні від 2 до 10.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateMatrixContent())
            {
                MessageBox.Show("Некоректний ввід елементів матриці.\nЕлементи матриці мають бути дійсними числами від -100 до 100 та їх кількість має відповідати розмірності.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Matrix matrixMain = Matrix.ReadMatrix(textBoxSize, textBoxMatrix);
            LUPDecomposition matrix = new LUPDecomposition(matrixMain.size, matrixMain.matrix);

            double det = Determinant(matrix);

            if (det != 0)
            {
                labelLUP.Text = WriteMatrix(matrix.Inverse());
                labelCompLUP.Text = matrix.comparisons.ToString();
            }
            else
            {
                MessageBox.Show("Визначник матриці рівний нулю. Обертання матриці обчислити не можливо!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (!ValidateMatrixSize())
            {
                MessageBox.Show("Некоректний ввід розміру матриці.\nРозмір матриці повинен бути цілим числом в діапазоні від 2 до 10.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int size = Convert.ToInt32(textBoxSize.Text);
            textBoxMatrix.Text = WriteMatrix(GenerateRandomMatrix(size));
        }


        private void buttonFile_Click(object sender, EventArgs e)
        {
            string matrix = textBoxMatrix.Text;
            string schultz = labelSchultz.Text;
            string lup = labelLUP.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Початкова матриця:");
                        writer.WriteLine(matrix);
                        writer.WriteLine();
                        writer.WriteLine("Обернення методом Шульца:");
                        writer.WriteLine(schultz);
                        writer.WriteLine();
                        writer.WriteLine("Оберненя методом LUP-розкладу:");
                        writer.WriteLine(lup);
                    }

                    MessageBox.Show("Дані були збережені в файл " + filePath, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка при збереженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double Determinant(Matrix matrix)
        {
            int n = matrix.GetSize(), index;
            double[,] mat = Copy(matrix);
            double num1, num2, det = 1, total = 1;
            double[] temp = new double[n+1];

            for(int i = 0; i < n;i++)
            {
                index = i;

                while (index<n && mat[index,i]==0)
                {
                    index++;
                }

                if(index==n) { continue; }

                if(index != i)
                {
                    for(int j = 0; j < n; j++)
                    {
                        Swap(mat, index, j, i, j);
                    }
                    det = det * Math.Pow(-1, index - i);
                }

                for (int j = 0; j < n; j++)
                {
                    temp[j] = mat[i, j];
                }

                for (int j = i + 1; j < n; j++)
                {
                    num1 = temp[i];
                    num2 = mat[j,i]; 
                    for (int k = 0; k < n; k++)
                    {
                        mat[j, k] = (num1 * mat[j, k]) - (num2 * temp[k]);
                    }
                    total = total * num1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                det = det * mat[i, i];
            }
            return (det / total);
        }

        private double[,] Swap(double[,] arr, int i1, int j1, int i2, int j2)
        {
            double temp = arr[i1, j1];
            arr[i1, j1] = arr[i2, j2];
            arr[i2, j2] = temp;
            return arr;
        }

        private double[,] Copy(Matrix matrix)
        {
            int n = matrix.GetSize();
            double[,] mat = matrix.GetMatrix();

            double[,] matNew = new double[n, n];
            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    matNew[i, j] = mat[i, j];
                }
            }

            return matNew;
        }


        private double[,] GenerateRandomMatrix(int size)
        {
            Random rand = new Random();
            double[,] matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(-100, 101);
                }
            }

            return matrix;
        }

        private void ClearErrors()
        {
            errorProvider1.Clear();
        }
        private bool ValidateMatrixSize()
        {
            string sizeInput = textBoxSize.Text.Trim();
            int size;

            if (!int.TryParse(sizeInput, out size))
                return false;

            if (size < 2 || size > 10)
                return false;

            return true;
        }
        private bool ValidateMatrixContent()
        {
            string matrixInput = textBoxMatrix.Text.Trim();
            string[] rows = matrixInput.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int size = int.Parse(textBoxSize.Text.Trim());
            int expectedElements = size * size;

            if (rows.Length != size)
                return false;

            foreach (string row in rows)
            {
                string[] elements = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (elements.Length != size)
                    return false;

                foreach (string element in elements)
                {
                    double value;
                    if (!double.TryParse(element, out value))
                        return false;
                    if(value < -100 || value > 100)
                        return false;
                }
            }

            return true;
        }

        private string WriteMatrix(double[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sb.Append(matrix[i, j]);

                    if (j < size - 1)
                    {
                        sb.Append(" ");
                    }
                }

                if (i < size - 1)
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        private void textBoxSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatrix_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
