namespace pudov.lab8._1
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random(); // ������� ������ Random ��� ���������� �������������
        private const double Threshold = 0.5; // ��������� ��� ���������� ��������

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();

            double value = _random.NextDouble(); // ���������� ��������� ��������

            // ���������� ��������� �������� ��� ���������� ����
            string result = value < Threshold ? "��" : (value > Threshold ? "���" : "�� ����");

            textBox2.Text = result; // ������� ���������
        }
    }
}
