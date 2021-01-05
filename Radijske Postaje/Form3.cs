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
    public partial class Form3 : Form
    {
        Form1 a;
        Form4 b;
        public Form3()
        {
            InitializeComponent();
        }

        public byte[] Hash(string data)
        {
            byte[] salt1 = new byte[8];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt1);
            }
            int myIterations = 1000;
            Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(data, salt1,myIterations);
            Aes encAlg = Aes.Create();
            encAlg.Key = k1.GetBytes(16);
            MemoryStream encryptionStream = new MemoryStream();
            CryptoStream encrypt = new CryptoStream(encryptionStream,encAlg.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] utfD1 = new System.Text.UTF8Encoding(false).GetBytes(data);
            return utfD1;
        }

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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBox1.Text;
                string priimek = textBox2.Text;
                int starost = Convert.ToInt32(textBox3.Text);
                string mail = textBox4.Text;
                string pass = textBox5.Text;
                string kraj = comboBox1.Text;
                char spol;
                if (radioButton1.Checked)
                {
                    spol = 'M';
                    //byte[] HashPass = Hash(pass);
                    //MessageBox.Show(Hgeslo);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT email FROM uporabniki WHERE (email = '" + mail + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string email = reader.GetString(0);
                                if (email == mail)
                                {
                                    MessageBox.Show("Uporabnik s tem mailom že obstaja");
                                }
                            }
                            
                        }
                        
                        else if (!reader.HasRows)
                        {
                            con.Close();
                            con.Open();
                            NpgsqlCommand com2 = new NpgsqlCommand("INSERT INTO uporabniki (ime, priimek, spol, starost, email, geslo, kraj_id) VALUES ('" + ime + "', '" + priimek + "', '" + spol + "', '" + starost + "', '" + mail + "', '" + pass + "', (SELECT id FROM kraji WHERE (ime = '" + kraj + "')))", con);
                            com2.ExecuteNonQuery();

                            b = new Form4();
                            Hide();
                            b.Show();
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                    
                else if (radioButton2.Checked)
                {
                    spol = 'Ž';
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT email FROM uporabniki WHERE (email = '" + mail + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string email = reader.GetString(0);
                                if (email == mail)
                                {
                                    MessageBox.Show("Uporabnik s tem mailom že obstaja");
                                }
                            }

                        }

                        else if (!reader.HasRows)
                        {
                            con.Close();
                            con.Open();
                            NpgsqlCommand com2 = new NpgsqlCommand("INSERT INTO uporabniki (ime, priimek, spol, starost, email, geslo, kraj_id) VALUES ('" + ime + "', '" + priimek + "', '" + spol + "', '" + starost + "', '" + mail + "', '" + pass + "', (SELECT id FROM kraji WHERE (ime = '" + kraj + "')))", con);
                            com2.ExecuteNonQuery();

                            b = new Form4();
                            Hide();
                            b.Show();
                        }

                        reader.Close();
                        con.Close();
                    }
                }  
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Napaka v formatu: " + ex.Message);
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Adlešiči";
            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(2);
                    comboBox1.Items.Add(ime);
                }
                con.Close();
            }
        }
    }
}
