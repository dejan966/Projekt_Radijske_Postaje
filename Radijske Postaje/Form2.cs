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
        List<string> postaje = new List<string>();
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
        }


        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string naslov = textBox1.Text;
                string frekvenca = textBox2.Text;
                string jezik = textBox3.Text;
                string zvrst = Convert.ToString(comboBox1.SelectedItem);
                string regija = Convert.ToString(comboBox2.SelectedItem);
                if (richTextBox1.Text == "Opis")
                    richTextBox1.Clear();

                if(textBox4.Text == "Spletna stran")
                    textBox4.Clear();

                if(textBox5.Text == "Youtube")
                    textBox5.Clear();

                if(textBox6.Text == "Twitter")
                    textBox6.Clear();

                if (richTextBox1.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
                {
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
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
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
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
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, spletna_stran, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
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
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, yt_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + yt + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
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
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + twitter + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (richTextBox1.Text == "" && textBox6.Text == "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    string stran = textBox4.Text;
                    string yt = textBox5.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, spletna_stran, yt_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + yt + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox4.Text == "" && richTextBox1.Text == "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    string yt = textBox5.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, yt_link, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + yt + "', '" + twitter + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox4.Text == "" && textBox5.Text == "" && richTextBox1.Text != "" && textBox6.Text != "")
                {
                    string opis = richTextBox1.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + twitter + "',(SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (richTextBox1.Text == "" && textBox5.Text == "" && textBox4.Text != "" && textBox6.Text != "")
                {
                    string stran = textBox4.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, spletna_stran, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + twitter + "',(SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (richTextBox1.Text != "" && textBox5.Text != "" && textBox4.Text == "" && textBox6.Text == "")
                {
                    string opis = richTextBox1.Text;
                    string yt = textBox5.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, yt_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + yt + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox6.Text == "" && textBox5.Text == "" && textBox4.Text != "" && richTextBox1.Text != "")
                {
                    string stran = textBox4.Text;
                    string opis = richTextBox1.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, spletna_stran, zvrst_id, regija_id) VALUES ('" + naslov + "','" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox6.Text != "" && textBox5.Text != "" && textBox4.Text != "" && richTextBox1.Text == "")
                {
                    string stran = textBox4.Text;
                    string yt = textBox5.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, spletna_stran, yt_link, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + yt + "', '" + twitter + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox6.Text != "" && textBox5.Text != "" && textBox4.Text == "" && richTextBox1.Text != "")
                {
                    string opis = richTextBox1.Text;
                    string yt = textBox5.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, yt_link, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + yt + "', '" + twitter + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox6.Text != "" && textBox5.Text == "" && textBox4.Text != "" && richTextBox1.Text != "")
                {
                    string opis = richTextBox1.Text;
                    string stran = textBox4.Text;
                    string twitter = textBox6.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, spletna_stran, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "',  '" + opis + "','" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + twitter + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (textBox6.Text == "" && textBox5.Text != "" && textBox4.Text != "" && richTextBox1.Text != "")
                {
                    string opis = richTextBox1.Text;
                    string stran = textBox4.Text;
                    string yt = textBox5.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, spletna_stran, yt_link, zvrst_id, regija_id) VALUES ('" + naslov + "',  '" + opis + "','" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + yt + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
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
                        NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, opis, frekvenca, jezik, spletna_stran, yt_link, twitter_link, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + yt + "', '" + twitter + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);

                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                postaje.Add(naslov + '|' + frekvenca + '|' + jezik + '|' + zvrst + '|' + regija);
                listBox1.Items.Clear();
                foreach (string item in postaje)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch(FormatException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
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
                    string ime = reader.GetString(0);
                    string priimek = reader.GetString(1);
                    Lbl_User.Text = "Prijavljeni ste kot " + ime + " " + priimek;
                }
                reader.Close();
                con.Close();
            }

            using (NpgsqlConnection con2 = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con2.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM zvrsti", con2);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(1);
                    comboBox1.Items.Add(ime);
                }
                reader.Close();
                con2.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM regije", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string regija = reader.GetString(1);
                    comboBox2.Items.Add(regija);
                }
                
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT rp.naslov, rp.frekvenca, rp.jezik, z.ime, r.ime FROM radijske_postaje rp INNER JOIN zvrsti z ON z.id = rp.zvrst_id INNER JOIN regije r ON rp.regija_id = r.id", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string naslov = reader.GetString(0);
                    string frekvenca = reader.GetString(1);
                    string jezik = reader.GetString(2);
                    string z_ime = reader.GetString(3);
                    string r_ime = reader.GetString(4);
                    postaje.Add(naslov + '|' + frekvenca + '|' + jezik + '|' + z_ime + '|' + r_ime);
                    listBox1.Items.Clear();
                    foreach (string item in postaje)
                    {
                        listBox1.Items.Add(item);
                    }

                }
                reader.Close();
                con.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Opis")
                richTextBox1.Clear();

            if (textBox4.Text == "Spletna stran")
                textBox4.Clear();

            if (textBox5.Text == "Youtube")
                textBox5.Clear();

            if (textBox6.Text == "Twitter")
                textBox6.Clear();

            Btn_Update.Enabled = true;
            Btn_Delete.Enabled = true;
            if(listBox1.SelectedIndex >= 0)
            {
                string allData = listBox1.Items[listBox1.SelectedIndex].ToString();
                string[] data = allData.Split('|');

                textBox1.Text = data[0];
                textBox2.Text = data[1];
                textBox3.Text = data[2];
                comboBox1.Text = data[3];
                comboBox2.Text = data[4];
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
