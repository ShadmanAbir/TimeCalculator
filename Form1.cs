namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int? onemin = Convert.ToInt32(textBox1.Text);
            int? fivemin = Convert.ToInt32(textBox2.Text);
            int? tenmin = Convert.ToInt32(textBox3.Text);
            int? min15 = Convert.ToInt32(textBox4.Text);
            int? min60 = Convert.ToInt32(textBox5.Text);
            int? hr3 = Convert.ToInt32(textBox6.Text);
            int? hr8 = Convert.ToInt32(textBox7.Text);
            int? hr24 = Convert.ToInt32(textBox8.Text);

            int totalMinutes = (int)((onemin * 1) + (fivemin * 5) + (tenmin * 10) + (min15 * 15) + (min60 * 60) + (hr3 * 180) + (hr8 * 480) + (hr24 * 1440));
            textBox9.Text = "Minute:" + totalMinutes.ToString() + "   Hour:" + (totalMinutes / 60).ToString() + "   Day:" + ((totalMinutes / 60) / 24).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.SelectNextControl((Control)sender, true, true, true, true);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SelectNextControl((Control)sender, false, true, true, true);
        }
    }
}