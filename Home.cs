using System;
using System.Windows.Forms;

namespace UNIFIT
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            INPUTORDERS dash = new INPUTORDERS();
            this.Hide();
            dash.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LISTOFORDERS dash = new LISTOFORDERS();
            this.Hide();
            dash.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ONGOING dash = new ONGOING();
            this.Hide();
            dash.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PENDING dash = new PENDING();
            this.Hide();
            dash.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CANCELLED dash = new CANCELLED();
            this.Hide();
            dash.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RECEIPT dash = new RECEIPT();
            this.Hide();
            dash.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            COMPLETED dash = new COMPLETED();
            this.Hide();
            dash.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MESSAGES dash = new MESSAGES();
            this.Hide();
            dash.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            INVENTORY dash = new INVENTORY();
            this.Hide();
            dash.ShowDialog();
        }
    }
}
