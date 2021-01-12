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

        /*public byte[] Hash(string data)
        {
            byte[] salt1 = new byte[8];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt1);
            }
            int myIterations = 1000;
            Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(data, salt1, myIterations);
            return salt1;
        }*/

        /*public string PassHash(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }

            return returnValue.ToString();
        }*/

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = "";
                string priimek = "";
                int starost = 1;
                string kraj = "";
                char spol = 'M';
                string email = textBox1.Text;
                string pass = textBox2.Text;

                //byte[] HashPass= Hash(pass);
                //MessageBox.Show(Hgeslo);

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM reg_prijava ('" + ime + "','" + priimek + "', '" + spol + "' , '" + starost + "' ,'" + email + "', '" + pass + "' , '" + kraj + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        string mail_b = reader.GetString(0);
                        string pass_b = reader.GetString(1);
                        if (email == mail_b && pass == pass_b)
                        {
                            Form1.ImeOsebe(email);
                            a = new Form1();
                            Hide();
                            a.Show();
                        }
                        else
                            MessageBox.Show("Napačno geslo ali mail");
                    }

                    reader.Close();
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
