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
    public partial class Form2 : Form
    {
        /*string a = "Naslov";
        string b = "Opis";
        string c = "Frekvenca";
        string d = "Jezik";
        string j = "Spletna stran";
        string f = "Youtube";
        string g = "Twitter";
        string h = "Zvrst";
        string i = "Regija";*/
        static String mail;
        public Form2()
        {
            InitializeComponent();
        }

        public static void ImeOsebe(String n1)
        {
            mail = n1;
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Naslov")
            {
                textBox1.Clear();
            }

            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "Opis")
            {
                richTextBox1.Clear();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "Frekvenca")
            {
                textBox2.Clear();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }

            if(richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "Jezik")
            {
                textBox3.Clear();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }

            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "Spletna stran")
            {
                textBox4.Clear();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == "Youtube")
            {
                textBox5.Clear();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if(textBox6.Text == "Twitter")
            {
                textBox6.Clear();
            }
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if(textBox7.Text == "Zvrst")
            {
                textBox7.Clear();
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "Regija";
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if(textBox8.Text == "Regija")
            {
                textBox8.Clear();
            }

            if(textBox1.Text == "")
            {
                textBox1.Text = "Naslov";
            }
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Opis";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Frekvenca";
            }

            if(textBox3.Text == "")
            {
                textBox3.Text = "Jezik";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "Spletna stran";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "Youtube";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "Twitter";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "Zvrst";
            }
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string naslov = textBox1.Text;
                string frekvenca = textBox2.Text;
                string jezik = textBox3.Text;
                string zvrst = textBox7.Text;
                string regija = textBox8.Text;

                if (richTextBox1.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postanje (naslov, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrste WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && richTextBox1.Text != "")
                {
                    string opis = richTextBox1.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postanje (naslov, opis, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrste WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if(richTextBox1.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox4.Text != "")
                {
                    string stran = textBox4.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postanje (naslov, spletna_stran, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + stran + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrste WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if(richTextBox1.Text == "" && textBox4.Text == "" && textBox6.Text == "" && textBox5.Text != "")
                {
                    string yt = textBox5.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postanje (naslov, yt_link, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + yt + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrste WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (richTextBox1.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text != "")
                {
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postanje (naslov, twitter_link, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + twitter + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrste WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (richTextBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    string opis = richTextBox1.Text;
                    string stran = textBox4.Text;
                    string yt = textBox5.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postanje (naslov, opis, frekvenca, jezik, spletna_stran, yt_link, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + yt + "', '" + twitter + "', (SELECT id FROM zvrste WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);

                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch { }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT ime, priimek FROM uporabniki WHERE (email = '" + mail+ "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(1);
                    string priimek = reader.GetString(2);
                    Lbl_User.Text = "Prijavljeni ste kot " + ime + priimek;
                }
                con.Close();
            }
        }
    }
}
