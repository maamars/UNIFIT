using System;
using System.Windows.Forms;

namespace UNIFIT
{

    public partial class LOGIN : Form
    {

        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username_textbox.Text == "ADMIN" && password_textbox.Text == "PASSWORD")
            {
                HOME dash = new HOME();
                this.Hide();
                dash.ShowDialog();

            }
            else
            {
                MessageBox.Show("ERROR! TRY AGAIN.");
            }


        }

        private void username_textbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
