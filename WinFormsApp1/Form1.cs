namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Rows.Add(0, 0);
            dataGridView1.Rows.Add(0, 0);
            dataGridView1.Rows[0].HeaderCell.Value = "1";
            dataGridView1.Rows[1].HeaderCell.Value = "2";

            dataGridView2.Rows.Add(0, 0);
            dataGridView2.Rows.Add(0, 0);
            dataGridView2.Rows[0].HeaderCell.Value = "1";
            dataGridView2.Rows[1].HeaderCell.Value = "2";
        }

        /// <summary>
        /// Настраивает таблицу DataGridView под заданный размер матрицы, расставляет нумерацию и при необходимости заполняет ячейки нулями.
        /// </summary>
        /// <param name="dgv">Элемент таблицы DataGridView, который нужно настроить.</param>
        /// <param name="rows">Количество строк матрицы.</param>
        /// <param name="cols">Количество столбцов матрицы.</param>
        /// <param name="fillZeros">Флаг заполнения ячеек нулями (true — заполнить нулями, false — оставить пустыми).</param>
        private void CreateMatrixGrid(DataGridView dgv, int rows, int cols, bool fillZeros)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersWidth = 50;

            for (int j = 0; j < cols; j++)
            {
                dgv.Columns.Add($"col_{j}", (j + 1).ToString());
                dgv.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < rows; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();

                if (fillZeros)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dgv.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Считывает числовые значения из таблицы DataGridView в двумерный массив.
        /// </summary>
        /// <param name="dgv">Таблица, из которой считываются данные.</param>
        /// <param name="matrix">Выходной двумерный массив чисел матрицы.</param>
        /// <returns>Возвращает true, если все ячейки успешно прочитаны; иначе false.</returns>
        private bool TryReadMatrix(DataGridView dgv, out double[,] matrix)
        {
            int rows = dgv.Rows.Count;
            int cols = dgv.Columns.Count;
            matrix = new double[rows, cols];

            if (rows == 0 || cols == 0)
            {
                MessageBox.Show("Матрица не создана! Сначала нажмите «Создать матрицы».",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string cellText = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    // Заменяем точку на запятую или наоборот, чтобы дробные числа читались без ошибок
                    cellText = cellText.Replace('.', ',');

                    if (!double.TryParse(cellText, out double val))
                    {
                        MessageBox.Show($"Некорректное число в строке {i + 1}, столбце {j + 1}!",
                            "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    matrix[i, j] = val;
                }
            }

            return true;
        }

        private void DisplayResultMatrix(double[,] result)
        {
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            CreateMatrixGrid(dataGridView3, rows, cols, false);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Округляем до 4 знаков после запятой для аккуратного отображения дробей
                    dataGridView3.Rows[i].Cells[j].Value = Math.Round(result[i, j], 4);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Создать матрицы»: проверяет введённые размеры и формирует таблицы для матриц A и B.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, что в текстовые поля введены целые числа
            bool isRowsA = int.TryParse(textBox1.Text, out int rowsA);
            bool isColsA = int.TryParse(textBox2.Text, out int colsA);
            bool isRowsB = int.TryParse(textBox3.Text, out int rowsB);
            bool isColsB = int.TryParse(textBox4.Text, out int colsB);
            if (!isRowsA || !isColsA || !isRowsB || !isColsB)
            {
                MessageBox.Show("Пожалуйста, введите целые числа во все поля размеров!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что размеры больше нуля (и не слишком огромные, чтобы форма не зависла)
            if (rowsA <= 0 || colsA <= 0 || rowsB <= 0 || colsB <= 0 || rowsA > 10 || colsA > 10 || rowsB > 10 || colsB > 10)
            {
                MessageBox.Show("Размеры матриц должны быть от 1 до 10!", "Ошибка размера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаём матрицы A и B и заполняем их нулями
            CreateMatrixGrid(dataGridView1, rowsA, colsA, true);
            CreateMatrixGrid(dataGridView2, rowsB, colsB, true);

            // Очищаем таблицу с результатом, так как размеры изменились
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «A + B»: складывает матрицы A и B одинакового размера.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!TryReadMatrix(dataGridView1, out double[,] matrixA) ||
                !TryReadMatrix(dataGridView2, out double[,] matrixB))
                return;

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (rowsA != rowsB || colsA != colsB)
            {
                MessageBox.Show("Для сложения матрицы A и B должны иметь одинаковый размер!",
                    "Ошибка размерности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double[,] result = new double[rowsA, colsA];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            DisplayResultMatrix(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!TryReadMatrix(dataGridView1, out double[,] matrixA) ||
                !TryReadMatrix(dataGridView2, out double[,] matrixB))
                return;

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (rowsA != rowsB || colsA != colsB)
            {
                MessageBox.Show("Для вычитания матрицы A и B должны иметь одинаковый размер!",
                    "Ошибка размерности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double[,] result = new double[rowsA, colsA];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    result[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }

            DisplayResultMatrix(result);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «A × B»: перемножает матрицу A на матрицу B.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (!TryReadMatrix(dataGridView1, out double[,] matrixA) ||
                !TryReadMatrix(dataGridView2, out double[,] matrixB))
                return;

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB)
            {
                MessageBox.Show("Для умножения количество столбцов матрицы A должно равняться количеству строк матрицы B!",
                    "Ошибка размерности", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double[,] result = new double[rowsA, colsB];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            DisplayResultMatrix(result);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Транспонировать A»: меняет строки и столбцы матрицы A местами.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!TryReadMatrix(dataGridView1, out double[,] matrixA))
                return;

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);

            double[,] result = new double[colsA, rowsA];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    result[j, i] = matrixA[i, j];
                }
            }

            DisplayResultMatrix(result);
        }
    }
}
