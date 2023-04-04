namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Input_Click(object sender, EventArgs e)
        {
            textBox1Name.Text = "OZCANAKYUZ";
        }

        private void textBox1Name_TextChanged(object sender, EventArgs e)
        {
            textBox1Name.ForeColor = Color.White;
        }

        private void button2Output_Click(object sender, EventArgs e)
        {
            textBox1Name.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1Nick.ForeColor= Color.Red;
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            label1Nick.Text = textBox1Name.Text;
        }

        private void buttonBoxEkle_Click(object sender, EventArgs e)
        {
            listBox1NickVolume.Items.Add(textBox1Name.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Green; comboBox1.SelectedIndex = 0;
        }

        private void buttonComboEkle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1Name.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1Marul_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1Marul.Checked = radioButton1Marul.Checked;
            Color.Green;
        }

        private void radioButton2Domates_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2Domates.Checked= radioButton2Domates.Checked;
            Color.Red;
        }

        private void radioButton3Zeytin_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3Zeytin.Checked= radioButton3Zeytin.Checked;
            Color.Black;
        }

        private void trackBar1Ses_Scroll(object sender, EventArgs e)
        {
            
            
        }

        private void button1Volume_Click(object sender, EventArgs e)
        {
            
            listBox1NickVolume.Text = button1Volume.Text;
        }
    }
}