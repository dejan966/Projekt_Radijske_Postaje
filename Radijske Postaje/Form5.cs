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
    public partial class Form5 : Form
    {
        Form4 a;
        static String mail;
        public Form5()
        {
            InitializeComponent();
        }

        public static void Mail(String n2)
        {
            mail = n2;
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string novoGeslo = textBox1.Text;
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();

                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM new_pass ('" + mail + "' ,'" + novoGeslo + "')", con);
                    com.ExecuteNonQuery();

                    con.Close();
                }
                a = new Form4();
                a.Show();
                Hide();
            }
            else
                MessageBox.Show("Morate vnesti novo geslo");
            
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            a = new Form4();
            a.Show();
            Hide();
        }
    }
}
