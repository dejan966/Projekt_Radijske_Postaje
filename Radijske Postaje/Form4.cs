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
using System.IO;
using System.Security.Cryptography;

namespace Radijske_Postaje
{
    public partial class Form4 : Form
    {
        Form1 a;
        
        Form5 c;
        public Form4()
        {
            InitializeComponent();
        }

        

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                
                string email = textBox1.Text;
                string pass = textBox2.Text;

                string hash2 = Form3.PassHash(pass);
                //MessageBox.Show(hash2);
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM login ('" + email + "', '" + hash2 + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        string mail_b = reader.GetString(0);
                        string pass_b = reader.GetString(1);
                        if (email == mail_b && hash2 == pass_b)
                        {
                            Form1.ImeOsebe(email);
                            a = new Form1();
                            Hide();
                            a.Show();
                        }
                        else
                            MessageBox.Show("Napačno geslo ali mail");
                    }

                    
                    con.Close();
                }
                
            }
            catch { }
        }

        private void Lbl_Pozabljeno_geslo_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "")
            {
                MessageBox.Show("Prosim vpišite mail");
            }
            else if(textBox1.Text != "")
            {
                string m = textBox1.Text;
                Form5.Mail(m);
                c = new Form5();
                Hide();
                c.Show();
            }
            
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();
        }
    }
}
