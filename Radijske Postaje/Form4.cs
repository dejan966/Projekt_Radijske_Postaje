using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Radijske_Postaje
{
    public partial class Form4 : Form
    {
        Form2 a;
        public Form4()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            a = new Form2();
            Hide();
            a.Show();
        }

        private void Lbl_Pozabljeno_geslo_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
