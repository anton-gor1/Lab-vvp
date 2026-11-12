using System.Reflection.Emit;

namespace task18_4
{
    public partial class Form1 : Form
    {
        public struct Aeroflot
        {
            // Структура для хранения данных об одном авиарейсе
            public string Destination; // Пункт назначения
            public string FlightNumber; // Номер рейса
            public string PlaneType;   // Тип самолёта
        }

        // Массив на 7 рейсов и имя файла для сохранения базы
        private Aeroflot[] flights = new Aeroflot[7];
        private const string DataFileName = "flights_data.txt";

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(7);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Сохранить данные»: считывает 7 рейсов из таблицы в массив структур и сохраняет в файл.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Завершаем редактирование текущей ячейки, чтобы последнее введённое значение не потерялось
            dataGridView1.EndEdit();

            for (int i = 0; i < 7; i++)
            {
                string dest = dataGridView1.Rows[i].Cells[0].Value?.ToString()?.Trim() ?? "";
                string num = dataGridView1.Rows[i].Cells[1].Value?.ToString()?.Trim() ?? "";
                string plane = dataGridView1.Rows[i].Cells[2].Value?.ToString()?.Trim() ?? "";

                if (string.IsNullOrEmpty(dest) || string.IsNullOrEmpty(num) || string.IsNullOrEmpty(plane))
                {
                    MessageBox.Show($"Заполните все ячейки в строке №{i + 1}!", "Неполные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                flights[i] = new Aeroflot
                {
                    Destination = dest,
                    FlightNumber = num,
                    PlaneType = plane
                };
            }
            // Записываем данные в файл через разделитель ';'
            using (StreamWriter writer = new StreamWriter(DataFileName))
            {
                foreach (var flight in flights)
                {
                    writer.WriteLine($"{flight.Destination};{flight.FlightNumber};{flight.PlaneType}");
                }
            }

            label2.Text = "Данные о семи рейсах успешно сохранены.";
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Записать список в текстовый файл»: сохраняет текущий список в читаемый отчёт.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flights[0].Destination))
            {
                MessageBox.Show("Сначала сохраните или загрузите данные о рейсах!", "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открываем стандартное окно выбора места сохранения файла
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                saveDialog.FileName = "Список_рейсов.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine("СПИСОК АВИАРЕЙСОВ:");
                        writer.WriteLine(new string('-', 50));
                        foreach (var f in flights)
                        {
                            writer.WriteLine($"Пункт назначения: {f.Destination} | Рейс: {f.FlightNumber} | Самолёт: {f.PlaneType}");
                        }
                    }
                    label2.Text = $"Список записан в файл: {Path.GetFileName(saveDialog.FileName)}";
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Загрузить и сортировать»: читает рейсы из файла, сортирует по пункту назначения и выводит в таблицу.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(DataFileName))
            {
                MessageBox.Show("Файл с сохранёнными данными не найден! Сначала нажмите «Сохранить данные».", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(DataFileName);
            if (lines.Length < 7)
            {
                MessageBox.Show("Файл данных повреждён или содержит меньше 7 записей.", "Ошибка файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < 7; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length == 3)
                {
                    flights[i] = new Aeroflot
                    {
                        Destination = parts[0],
                        FlightNumber = parts[1],
                        PlaneType = parts[2]
                    };
                }
            }

            // Сортируем массив по алфавиту по полю Пункт назначения
            flights = flights.OrderBy(f => f.Destination).ToArray();

            // Обновляем таблицу отсортированными данными
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = flights[i].Destination;
                dataGridView1.Rows[i].Cells[1].Value = flights[i].FlightNumber;
                dataGridView1.Rows[i].Cells[2].Value = flights[i].PlaneType;
            }

            label2.Text = "Данные загружены и отсортированы по пункту назначения.";
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки «Найти рейсы»: ищет рейсы по введённому пункту назначения и выводит номера и типы самолётов.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            string searchCity = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchCity))
            {
                MessageBox.Show(
                    "Введите пункт назначения для поиска!",
                    "Пустой запрос",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var foundFlights = flights
                .Where(f => !string.IsNullOrWhiteSpace(f.Destination) &&
                            f.Destination.Equals(
                                searchCity,
                                StringComparison.OrdinalIgnoreCase))
                .Select(f => $"Рейс №{f.FlightNumber} ({f.PlaneType})")
                .ToList();

            if (foundFlights.Count > 0)
            {
                label2.Text = $"Рейсы в пункт назначения «{searchCity}»: " +
                              string.Join(", ", foundFlights);
            }
            else
            {
                label2.Text = $"Рейсов в пункт назначения «{searchCity}» не найдено.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchCity = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchCity))
            {
                MessageBox.Show("Введите пункт назначения для поиска!", "Пустой запрос", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> foundInfo = new List<string>();

            // Ищем совпадения в массиве структур без учёта регистра
            foreach (var f in flights)
            {
                if (!string.IsNullOrEmpty(f.Destination) &&
                    f.Destination.Equals(searchCity, StringComparison.OrdinalIgnoreCase))
                {
                    foundInfo.Add($"Рейс №{f.FlightNumber} ({f.PlaneType})");
                }
            }

            if (foundInfo.Count > 0)
            {
                label2.Text = $"Рейсы в г. {searchCity}: " + string.Join(", ", foundInfo);
            }
            else
            {
                label2.Text = $"Рейсов в пункт назначения «{searchCity}» не найдено.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
    }
}
