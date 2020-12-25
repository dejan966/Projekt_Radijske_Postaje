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
    public partial class Form3 : Form
    {
        Form1 a;
        Form4 b;
        public Form3()
        {
            InitializeComponent();
        }



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
                string kraj = Convert.ToString(comboBox1.SelectedItem);
                char spol;
                if (radioButton1.Checked)
                {
                    spol = 'M';
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT email FROM uporabniki WHERE (email = '" + mail + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            string email = reader.GetString(0);
                            if (email == mail)
                                MessageBox.Show("Tak mail že obstaja");
                            else if (email != mail)
                            {
                                NpgsqlCommand com2 = new NpgsqlCommand("INSERT INTO uporabniki (ime, priimek, spol, starost, email, geslo, kraj_id) VALUES ('" + ime + "', '" + priimek + "', '" + spol + "', '" + starost + "', '" + mail + "', '" + pass + "', (SELECT id FROM kraji WHERE (ime = '" + kraj + "')))", con);
                                com2.ExecuteNonQuery();

                                b = new Form4();
                                Hide();
                                b.Show();
                            }

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
                        while (reader.Read())
                        {
                            string email = reader.GetString(5);
                            if (email == mail)
                                MessageBox.Show("Tak mail že obstaja");
                            else if (email != mail)
                            {
                                NpgsqlCommand com2 = new NpgsqlCommand("INSERT INTO uporabniki (ime, priimek, spol, starost, email, geslo, kraj_id) VALUES ('" + ime + "', '" + priimek + "', '" + spol + "', '" + starost + "', '" + mail + "'. '" + pass + "', (SELECT id FROM kraji WHERE (ime = '" + kraj + "'))", con);
                                com2.ExecuteNonQuery();

                                b = new Form4();
                                Hide();
                                b.Show();
                            }

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

            }
        }
    }
}
