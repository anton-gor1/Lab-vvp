using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace task16_5a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Time
        {
            public int hour;
            public int min;
            public int sec;

            // Вспомогательный метод для перевода времени в общее количество секунд с начала суток
            public int ToTotalSeconds()
            {
                return hour * 3600 + min * 60 + sec;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, что во все 6 полей введены целые числа
            bool okH1 = int.TryParse(txtHour1.Text, out int h1);
            bool okM1 = int.TryParse(txtMin1.Text, out int m1);
            bool okS1 = int.TryParse(txtSec1.Text, out int s1);

            bool okH2 = int.TryParse(txtHour2.Text, out int h2);
            bool okM2 = int.TryParse(txtMin2.Text, out int m2);
            bool okS2 = int.TryParse(txtSec2.Text, out int s2);

            if (!okH1 || !okM1 || !okS1 || !okH2 || !okM2 || !okS2)
            {
                MessageBox.Show("Введите целые числа во все поля времени!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Проверяем границы суток (часы: 0–23, минуты и секунды: 0–59)
            if (h1 < 0 || h1 > 23 || m1 < 0 || m1 > 59 || s1 < 0 || s1 > 59 ||
                h2 < 0 || h2 > 23 || m2 < 0 || m2 > 59 || s2 < 0 || s2 > 59)
            {
                MessageBox.Show("Часы должны быть от 0 до 23, а минуты и секунды — от 0 до 59!", "Некорректное время", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Создаём и заполняем две структуры типа Time
            Time t1 = new Time { hour = h1, min = m1, sec = s1 };
            Time t2 = new Time { hour = h2, min = m2, sec = s2 };

            // 4. Сравниваем время и меняем текст у Label (замените lblResult на ваше имя метки)
            int totalSec1 = t1.ToTotalSeconds();
            int totalSec2 = t2.ToTotalSeconds();

            if (totalSec1 < totalSec2)
            {
                label1.Text = $"Да, время t1 ({h1:D2}:{m1:D2}:{s1:D2}) предшествует времени t2 ({h2:D2}:{m2:D2}:{s2:D2}).";
            }
            else if (totalSec1 > totalSec2)
            {
                label1.Text = $"Нет, время t1 ({h1:D2}:{m1:D2}:{s1:D2}) позже времени t2 ({h2:D2}:{m2:D2}:{s2:D2}).";
            }
            else
            {
                label1.Text = $"Нет, время t1 и t2 полностью совпадает ({h1:D2}:{m1:D2}:{s1:D2}).";
            }
        }

        private void txtHour1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMin1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSec1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
