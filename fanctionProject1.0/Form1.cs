namespace fanctionProject1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cube()
        {
            int x = int.Parse(textBox1.Text);
            return 12 * x;
        }
        int cubeArea()
        {
            int x = int.Parse(textBox1.Text);
            return 6 * x * x;
        }
        int cubeVolume()
        {
            int x = int.Parse(textBox1.Text);
            return x * x * x;
        }
        int total()
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            return a + b;
        }

        int subtract()
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            return a - b;
        }

        int multiply()
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            return a * b;
        }

        int divide()
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cube();
            cubeArea();
            cubeVolume();
            label4.Text = " " + cubeArea();
            label6.Text = " " + cubeVolume();
            label5.Text = " " + cube();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            total();
            label13.Text = " " + total();
            label14.Text = " " + subtract();
            label15.Text = " " + multiply();
            label16.Text = " " + divide();

        }

    }
}
