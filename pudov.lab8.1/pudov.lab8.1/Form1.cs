namespace pudov.lab8._1
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random(); // Создаем объект Random для повторного использования
        private const double Threshold = 0.5; // Константа для порогового значения

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();

            double value = _random.NextDouble(); // Генерируем случайное значение

            // Используем тернарный оператор для сокращения кода
            string result = value < Threshold ? "ДА" : (value > Threshold ? "НЕТ" : "НЕ ЗНАЮ");

            textBox2.Text = result; // Выводим результат
        }
    }
}
