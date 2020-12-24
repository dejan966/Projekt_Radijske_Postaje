using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radijske_Postaje
{
    public partial class Form1 : Form
    {
        Form3 a;
        Form4 b;
        public Form1()
        {
            InitializeComponent();            
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            a = new Form3();
            Hide();
            a.Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            b = new Form4();
            Hide();
            b.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
