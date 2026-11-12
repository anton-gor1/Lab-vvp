namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Выполнить»: меняет местами каждые два соседних слова во введённом тексте.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Введите текст для обработки!", "Пустое поле", MessageBoxButtons.OK);
                return;
            }

            // Разбиваем текст на слова по пробелам, переносам строк и табуляции, убирая пустые элементы
            string[] words = inputText.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Идем по массиву с шагом 2 и меняем соседние сллова местами
            for (int i = 0; i < words.Length - 1; i += 2)
            {
                string temp = words[i];
                words[i] = words[i + 1];
                words[i + 1] = temp;
            }

            textBox2.Text = string.Join(" ", words);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Выполнить»: исправляет орфографические ошибки в сочетаниях жи, ши, ча, ща, чу, щу и подсчитывает их количество.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox3.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите текст для проверки!", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Словарь ошибочных сочетаний и их правильных вариантов (с учётом регистра)
            string[,] rules = new string[,]
            {
                { "жы", "жи" }, { "Жы", "Жи" }, { "ЖЫ", "ЖИ" },
                { "шы", "ши" }, { "Шы", "Ши" }, { "ШЫ", "ШИ" },
                { "чя", "ча" }, { "Чя", "Ча" }, { "ЧЯ", "ЧА" },
                { "щя", "ща" }, { "Щя", "Ща" }, { "ЩЯ", "ЩА" },
                { "чю", "чу" }, { "Чю", "Чу" }, { "ЧЮ", "ЧУ" },
                { "щю", "щу" }, { "Щю", "Щу" }, { "ЩЮ", "ЩУ" }
            };

            int fixedCount = 0;

            // Проходим по всем правилам замены
            for (int i = 0; i < rules.GetLength(0); i++)
            {
                string wrong = rules[i, 0];
                string right = rules[i, 1];

                // Считаем, сколько раз ошибочное сочетание встречается в тексте
                int index = 0;
                while ((index = text.IndexOf(wrong, index, StringComparison.Ordinal)) != -1)
                {
                    fixedCount++;
                    index += wrong.Length;
                }

                // Выполняем замену
                text = text.Replace(wrong, right);
            }

            textBox4.Text = $"Исправлено сочетаний: {fixedCount}\r\n\r\n{text}";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Выполнить»: находит и выводит все строки текста, заканчивающиеся восклицательным знаком.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            string inputText = textBox5.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Введите текст для поиска строк!", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Разбиваем весь текст на массив строк по символам переноса
            string[] lines = inputText.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> resultLines = new List<string>();

            // Проверяем каждую строку
            foreach (string line in lines)
            {
                // Убираем случайные пробелы в конце строки и проверяем последний символ
                if (line.TrimEnd().EndsWith("!"))
                {
                    resultLines.Add(line);
                }
            }

            if (resultLines.Count > 0)
            {
                textBox6.Text = string.Join("\r\n", resultLines);
            }
            else
            {
                textBox6.Text = "Строк, заканчивающихся восклицательным знаком, не найдено.";
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Выполнить»: находит и выводит фамилии абонентов, проживающих на улице Ленина.
        /// </summary>
        /// <param name="sender">Источник события (нажатая кнопка).</param>
        /// <param name="e">Данные о событии клика.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            string inputText = textBox7.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Введите список абонентов!", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Разбиваем весь текст на отдельные строки
            string[] lines = inputText.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> foundSurnames = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split('-', StringSplitOptions.RemoveEmptyEntries);

                // Проверяем, что в строке есть минимум два блока: ФИО и улица
                if (parts.Length >= 2)
                {
                    string fullName = parts[0].Trim();
                    string street = parts[1].Trim();

                    // Проверяем, содержит ли название улицы слово «Ленина» без учёта регистра
                    if (street.ToLower().Contains("ленина"))
                    {
                        // Берём только фамилию (первое слово до пробела из блока «Фамилия И.О.»)
                        string surname = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                        foundSurnames.Add(surname);
                    }
                }
            }

            if (foundSurnames.Count > 0)
            {
                textBox8.Text = string.Join("\r\n", foundSurnames);
            }
            else
            {
                textBox8.Text = "Абонентов, проживающих на улице Ленина, не найдено.";
            }
        }
    }
}