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
        Form1 a;
        Form4 b;
        Form3 c;
        static String Ime, Priimek;
        static String u;
        string l_opis;
        string r_opis;
        string r_splStran;
        string r_yt;
        string r_tw;
        int id_r;
        int id_l;
        List<string> postaje = new List<string>();
        List<string> studiji = new List<string>();
        public Form2()
        {
            InitializeComponent();
            
        }

        public void Opis_L(string l)
        {
            l_opis = l;
        }

        public void Opis(string a) {
            r_opis = a;
        }

        public void splStran(string b)
        {
            r_splStran = b;
        }

        public void YT(string c)
        {
            r_yt = c;
        }

        public void TW(string d)
        {
            r_tw = d;
        }

        public void IDpostaje(int z)
        {
            id_r = z;
        }

        public void IDstudija(int p)
        {
            id_l = p;
        }

        public static void User(string n1, string n2)
        {
            Ime = n1;
            Priimek = n2;
        }

        public static void Mail(string k)
        {
            u = k;
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

            if (textBox2.Text == "")
                textBox2.Text = "Frekvenca";

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
            string naslov = textBox1.Text;
            string frekvenca = textBox2.Text;
            string jezik = textBox3.Text;
            string zvrst = comboBox1.Text;
            string regija = comboBox2.Text;
            /*if (richTextBox1.Text == "Opis")
                richTextBox1.Clear();

            if(textBox4.Text == "Spletna stran")
                textBox4.Clear();

            if(textBox5.Text == "Youtube")
                textBox5.Clear();

            if(textBox6.Text == "Twitter")
                textBox6.Clear();*/

            if(Lbl_User.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if(Lbl_User.Text != "Niste prijavljeni")
            {
                if (textBox1.Text == "Naslov" && textBox2.Text == "Frekvenca" && textBox3.Text == "Jezik")
                {
                    MessageBox.Show("Morate vnesti vsaj to kar je označeno z zvezdico");
                }
                else if (textBox1.Text != "Naslov" && textBox2.Text != "Frekvenca" && textBox3.Text != "Jezik")
                {
                    comboBox4.Items.Add(naslov);
                    comboBox4.Text = naslov;
                    if (richTextBox1.Text == "Opis" && textBox4.Text == "Spletna stran" && textBox5.Text == "Youtube" && textBox6.Text == "Twitter")
                    {
                        using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                        {

                            con.Open();
                            NpgsqlCommand com = new NpgsqlCommand("INSERT INTO radijske_postaje (naslov, frekvenca, jezik, zvrst_id, regija_id) VALUES ('" + naslov + "', '" + frekvenca + "', '" + jezik + "', (SELECT id FROM zvrsti WHERE (ime = '" + zvrst + "')), (SELECT id FROM regije WHERE (ime = '" + regija + "')))", con);
                            com.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else if (textBox4.Text == "Spletna stran" && textBox5.Text == "Youtube" && textBox6.Text == "Twitter" && richTextBox1.Text != "Opis")
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
                    else if (richTextBox1.Text == "Opis" && textBox5.Text == "Youtube" && textBox6.Text == "Twitter" && textBox4.Text != "Spletna stran")
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
                    else if (richTextBox1.Text == "Opis" && textBox4.Text == "Spletna stran" && textBox6.Text == "Twitter" && textBox5.Text != "Youtube")
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
                    else if (richTextBox1.Text == "Opis" && textBox4.Text == "Spletna stran" && textBox5.Text == "Youtube" && textBox6.Text != "Twitter")
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
                    else if (richTextBox1.Text == "Opis" && textBox6.Text == "Twitter" && textBox4.Text != "Spletna stran" && textBox5.Text != "Youtube")
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
                    else if (textBox4.Text == "Spletna stran" && richTextBox1.Text == "Opis" && textBox5.Text != "Youtube" && textBox6.Text != "Twitter")
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
                    else if (textBox4.Text == "Spletna stran" && textBox5.Text == "Youtube" && richTextBox1.Text != "Opis" && textBox6.Text != "Twitter")
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
                    else if (richTextBox1.Text == "Opis" && textBox5.Text == "Youtube" && textBox4.Text != "Spletna stran" && textBox6.Text != "Twitter")
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
                    else if (richTextBox1.Text != "Opis" && textBox5.Text != "Youtube" && textBox4.Text == "Spletna stran" && textBox6.Text == "Twitter")
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
                    else if (textBox6.Text == "Twitter" && textBox5.Text == "Youtube" && textBox4.Text != "Spletna stran" && richTextBox1.Text != "Opis")
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
                    else if (textBox6.Text != "Twitter" && textBox5.Text != "Youtube" && textBox4.Text != "Spletna stran" && richTextBox1.Text == "Opis")
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
                    else if (textBox6.Text != "Twitter" && textBox5.Text != "Youtube" && textBox4.Text == "Spletna stran" && richTextBox1.Text != "Opis")
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
                    else if (textBox6.Text != "Twitter" && textBox5.Text == "Youtube" && textBox4.Text != "Spletna stran" && richTextBox1.Text != "Opis")
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
                    else if (textBox6.Text == "Twitter" && textBox5.Text != "Youtube" && textBox4.Text != "Spletna stran" && richTextBox1.Text != "Opis")
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
                    else if (richTextBox1.Text != "Opis" && textBox4.Text != "Spletna stran" && textBox5.Text != "Youtube" && textBox6.Text != "Twitter")
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

                    richTextBox1.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Btn_Odjava.Visible = false;
            Btn_Odjava_L.Visible = false;
            Btn_Prijava.Visible = false;
            Btn_Prijava_L.Visible = false;
            Btn_Reg.Visible = false;
            Btn_Reg_L.Visible = false;
            comboBox1.Text = "rock";
            comboBox2.Text = "Gorenjska";
            comboBox3.Text = "Adlešiči";
            //comboBox4.Text = "";

            User(Ime, Priimek);
            if (Ime == null && Priimek == null || Ime == "" && Priimek == "")
            {
                Lbl_User.Text = "Niste prijavljeni";
                Lbl_User_L.Text = "Niste prijavljeni";
                u = "";
                Form1.ImeOsebe(u);
            }
            else if (Ime != null && Priimek != null || Ime != "" && Priimek != "")
            {
                Lbl_User.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;
                Lbl_User_L.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;
                Btn_Odjava.Visible = true;
                Btn_Odjava_L.Visible = true;
            }
            if (Lbl_User.Text == "Niste prijavljeni" && Lbl_User_L.Text=="Niste prijavljeni")
            {
                Btn_Prijava.Visible = true;
                Btn_Prijava_L.Visible = true;
                Btn_Reg.Visible = true;
                Btn_Reg_L.Visible = true;
                u = "";
                Form1.ImeOsebe(u);
            }

            else if (Lbl_User.Text == "Prijavljeni ste kot " + Ime + " " + Priimek && Lbl_User_L.Text == "Prijavljeni ste kot " + Ime + " " + Priimek)
            {
                Btn_Odjava_L.Visible = true;
                Btn_Odjava.Visible = true;
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM radijske_postaje", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string naslov = reader.GetString(1);
                    comboBox4.Items.Add(naslov);
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {

                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(2);
                    comboBox3.Items.Add(ime);
                }
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

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT l.ime, k.ime, rp.naslov FROM lokalni_studiji l INNER JOIN radijske_postaje rp ON l.radijska_postaja_id = rp.id INNER JOIN kraji k ON l.kraj_id = k.id", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime_s = reader.GetString(0);
                    string s_kraj = reader.GetString(1);
                    string postaja_r = reader.GetString(2);

                    studiji.Add(ime_s + '|' + s_kraj + '|' + postaja_r);
                    listBox2.Items.Clear();
                    foreach (string item in studiji)
                    {
                        listBox2.Items.Add(item);
                    }
                }
                con.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Insert.Enabled = false;
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

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT rp.id FROM radijske_postaje rp INNER JOIN zvrsti z ON z.id = rp.zvrst_id INNER JOIN regije r ON r.id = rp.regija_id WHERE (rp.naslov = '" + textBox1.Text + "') AND (rp.frekvenca = '" + textBox2.Text + "') AND (rp.jezik = '" + textBox3.Text + "') AND (z.ime = '" + comboBox1.Text + "') AND (r.ime = '" + comboBox2.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);

                        IDpostaje(id);
                    }
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT rp.opis FROM radijske_postaje rp INNER JOIN zvrsti z ON z.id = rp.zvrst_id INNER JOIN regije r ON r.id = rp.regija_id WHERE (rp.naslov = '" + textBox1.Text + "') AND (rp.frekvenca = '" + textBox2.Text + "') AND (rp.jezik = '" + textBox3.Text + "') AND (z.ime = '" + comboBox1.Text + "') AND (r.ime = '" + comboBox2.Text + "') AND (rp.opis IS NOT NULL)", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            string opis = reader.GetString(0);
                            Opis(opis);
                            richTextBox1.Text = opis;
                        }
                    }
                    else if (!reader.HasRows)
                    {
                        richTextBox1.Clear();
                    }
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT rp.spletna_stran FROM radijske_postaje rp INNER JOIN zvrsti z ON z.id = rp.zvrst_id INNER JOIN regije r ON r.id = rp.regija_id WHERE (rp.naslov = '" + textBox1.Text + "') AND (rp.frekvenca = '" + textBox2.Text + "') AND (rp.jezik = '" + textBox3.Text + "') AND (z.ime = '" + comboBox1.Text + "') AND (r.ime = '" + comboBox2.Text + "') AND (rp.spletna_stran IS NOT NULL)", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string stran = reader.GetString(0);
                            splStran(stran);
                            textBox4.Text = stran;
                        }
                    }
                    else if (!reader.HasRows)
                    {
                        textBox4.Clear();
                    }
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT rp.yt_link FROM radijske_postaje rp INNER JOIN zvrsti z ON z.id = rp.zvrst_id INNER JOIN regije r ON r.id = rp.regija_id WHERE (rp.naslov = '" + textBox1.Text + "') AND (rp.frekvenca = '" + textBox2.Text + "') AND (rp.jezik = '" + textBox3.Text + "') AND (z.ime = '" + comboBox1.Text + "') AND (r.ime = '" + comboBox2.Text + "') AND (rp.yt_link IS NOT NULL)", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string yt = reader.GetString(0);
                            YT(yt);
                            textBox5.Text = yt;
                        }
                    }
                    else if (!reader.HasRows)
                    {
                        textBox5.Clear();
                    }
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT rp.twitter_link FROM radijske_postaje rp INNER JOIN zvrsti z ON z.id = rp.zvrst_id INNER JOIN regije r ON r.id = rp.regija_id WHERE (rp.naslov = '" + textBox1.Text + "') AND (rp.frekvenca = '" + textBox2.Text + "') AND (rp.jezik = '" + textBox3.Text + "') AND (z.ime = '" + comboBox1.Text + "') AND (r.ime = '" + comboBox2.Text + "') AND (rp.twitter_link IS NOT NULL)", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string twitter = reader.GetString(0);
                            TW(twitter);
                            textBox6.Text = twitter;
                        }
                    }
                    else if (!reader.HasRows)
                    {
                        textBox6.Clear();
                    }
                    con.Close();
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Opis(r_opis);
            splStran(r_splStran);
            YT(r_yt);
            TW(r_tw);
            if (Lbl_User.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User.Text != "Niste prijavljeni")
            {

                if (r_opis != richTextBox1.Text || r_splStran != textBox4.Text || r_yt != textBox5.Text || r_tw != textBox6.Text)
                {
                    Btn_Insert.Enabled = true;
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;

                    IDpostaje(id_r);

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        if (richTextBox1.Text != "Opis" && richTextBox1.Text != "")
                        {
                            NpgsqlCommand com2 = new NpgsqlCommand("UPDATE radijske_postaje SET opis = '" + richTextBox1.Text + "' WHERE (id = '" + id_r + "')", con);
                            com2.ExecuteNonQuery();
                        }

                        if (textBox4.Text != "Spletna stran" && textBox4.Text != "")
                        {
                            NpgsqlCommand com2 = new NpgsqlCommand("UPDATE radijske_postaje SET spletna_stran = '" + textBox4.Text + "' WHERE (id = '" + id_r + "')", con);
                            com2.ExecuteNonQuery();
                        }

                        if (textBox5.Text != "Youtube" && textBox5.Text != "")
                        {
                            NpgsqlCommand com2 = new NpgsqlCommand("UPDATE radijske_postaje SET yt_link = '" + textBox5.Text + "' WHERE (id = '" + id_r + "')", con);
                            com2.ExecuteNonQuery();
                        }

                        if (textBox6.Text != "Twitter" && textBox6.Text != "")
                        {
                            NpgsqlCommand com2 = new NpgsqlCommand("UPDATE radijske_postaje SET twitter_link = '" + textBox6.Text + "' WHERE (id = '" + id_r + "')", con);
                            com2.ExecuteNonQuery();
                        }
                        con.Close();
                    }


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
                else
                    MessageBox.Show("Morate nekaj spremeniti");
                
            }

            
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lbl_User.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User.Text != "Niste prijavljeni")
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    int i = listBox1.SelectedIndex;
                    postaje.RemoveAt(i);
                    listBox1.Items.Clear();
                    foreach (string item in postaje)
                    {
                        listBox1.Items.Add(item);
                    }

                    Btn_Insert.Enabled = true;
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;

                    IDpostaje(id_r);

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT radijska_postaja_id FROM lokalni_studiji WHERE (radijska_postaja_id = '" + id_r + "' )", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int r_id = reader.GetInt32(0);

                                using (NpgsqlConnection con3 = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                                {
                                    con3.Open();
                                    NpgsqlCommand com3 = new NpgsqlCommand("SELECT l.ime, k.ime, rp.naslov FROM lokalni_studiji l INNER JOIN kraji k ON l.kraj_id = k.id INNER JOIN radijske_postaje rp ON l.radijska_postaja_id = rp.id WHERE (l.radijska_postaja_id = '" + id_r + "')", con3);
                                    NpgsqlDataReader reader2 = com3.ExecuteReader();
                                    MessageBox.Show("ksfdsfi12");
                                    if (reader2.HasRows)
                                    {
                                        MessageBox.Show("ksfdsfi");
                                        while (reader2.Read())
                                        {
                                            string Lime = reader2.GetString(0);
                                            string Kime = reader2.GetString(1);
                                            string Pime = reader2.GetString(2);

                                            string skupaj = Lime + '|' + Kime + '|' + Pime;

                                            var studio = studiji.Single(r => r.Equals(skupaj));

                                            if (studio != null)
                                            {
                                                studiji.Remove(studio);

                                                listBox2.Items.Clear();
                                                foreach (string item in studiji)
                                                {
                                                    listBox2.Items.Add(item);
                                                }

                                                MessageBox.Show("ksi");
                                            }
                                            else
                                                MessageBox.Show("Null");
                                        }
                                    }
                                    else
                                        MessageBox.Show("kfsaf");

                                    con3.Close();
                                }

                                using (NpgsqlConnection con2 = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                                {
                                    con2.Open();
                                    NpgsqlCommand com2 = new NpgsqlCommand("DELETE FROM lokalni_studiji WHERE (radijska_postaja_id = '" + id_r + "')", con2);
                                    com2.ExecuteNonQuery();

                                    con2.Close();
                                    //MessageBox.Show("kfehr");
                                }

                                
                            }
                        }
                        
                        con.Close();
                    }

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("DELETE FROM radijske_postaje WHERE (id = '" + id_r + "')", con);
                        com.ExecuteNonQuery();

                        con.Close();
                    }

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

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox2 is readonly
            e.SuppressKeyPress = true;
        }

        private void Btn_Bck_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();
            
            Form1.ImeOsebe(u);
        }

        private void Btn_Odjava_Click(object sender, EventArgs e)
        {           
            u = "";
            Form1.ImeOsebe(u);
            Lbl_User.Text = "Niste prijavljeni";
            Lbl_User_L.Text = "Niste prijavljeni";

            Btn_Odjava.Visible = false;
            Btn_Prijava.Visible = true;
            Btn_Reg.Visible = true;

            Btn_Odjava_L.Visible = false;
            Btn_Prijava_L.Visible = true;
            Btn_Reg_L.Visible = true;
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            c = new Form3();
            Hide();
            c.Show();
        }

        private void Btn_Insert_L_Click(object sender, EventArgs e)
        {
            string s_ime = textBox7.Text;
            string kraj = comboBox3.Text;
            string r_postaja = comboBox4.Text;
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if(Lbl_User_L.Text != "Niste prijavljeni")
            {
                if(textBox7.Text == "Ime" || textBox7.Text == "")
                {
                    MessageBox.Show("Morate vnesti vsaj to kar je z zvezdico");
                }
                else if(textBox7.Text != "Ime" || textBox7.Text != "")
                {
                    if (richTextBox2.Text == "Opis" || richTextBox2.Text == "")
                    {
                        using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                        {
                            con.Open();
                            NpgsqlCommand com = new NpgsqlCommand("INSERT INTO lokalni_studiji (ime, kraj_id, radijska_postaja_id) VALUES ('" + s_ime + "', (SELECT id FROM kraji WHERE (ime = '" + kraj + "')), (SELECT id FROM radijske_postaje WHERE (naslov = '" + r_postaja + "')))", con);
                            com.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else if (richTextBox2.Text != "Opis" || richTextBox2.Text != "")
                    {
                        string opis_L = richTextBox2.Text;
                        using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                        {
                            con.Open();
                            NpgsqlCommand com = new NpgsqlCommand("INSERT INTO lokalni_studiji (ime, opis, kraj_id, radijska_postaja_id) VALUES ('" + s_ime + "', '" + opis_L + "', (SELECT id FROM kraji WHERE (ime = '" + kraj + "')), (SELECT id FROM radijske_postaje WHERE (naslov = '" + r_postaja + "')))", con);
                            com.ExecuteNonQuery();
                            con.Close();
                        }
                        textBox7.Clear();
                        richTextBox2.Clear();
                        comboBox3.Text = "";
                        comboBox4.Text = "";
                    }
                    studiji.Add(s_ime + '|' + kraj + '|' + r_postaja);
                    listBox2.Items.Clear();
                    foreach (string item in studiji)
                    {
                        listBox2.Items.Add(item);
                    }
                }
                
            }
            textBox7.Clear();
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void Btn_Update_L_Click(object sender, EventArgs e)
        {
            Opis_L(l_opis);
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                if(l_opis == richTextBox2.Text)
                {
                    MessageBox.Show("Morate nekaj spremeniti");
                }
                else if (l_opis != richTextBox2.Text)
                {
                    Btn_Insert_L.Enabled = true;
                    textBox7.ReadOnly = false;
                    IDstudija(id_l);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("UPDATE lokalni_studiji SET opis = '" + richTextBox2.Text + "' WHERE(id = '"+ id_l + "') ", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    textBox7.Clear();
                    richTextBox2.Clear();
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                }
            }
                
        }

        private void Btn_Delete_L_Click(object sender, EventArgs e)
        {
            IDstudija(id_l);
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                if(listBox2.SelectedIndex >= 0)
                {
                    int i = listBox2.SelectedIndex;
                    studiji.RemoveAt(i);
                    listBox2.Items.Clear();
                    foreach (string item in studiji)
                    {
                        listBox2.Items.Add(item);
                    }
                    Btn_Insert.Enabled = true;
                    Btn_Update_L.Enabled = false;
                    Btn_Delete_L.Enabled = false;
                    textBox7.ReadOnly = false;

                    IDstudija(id_l);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("DELETE FROM lokalni_studiji WHERE(id = '" + id_l + "') ", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    textBox7.Clear();
                    richTextBox2.Clear();
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                }
            }
                
        }

        private void Btn_Bck_L_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();

            Form1.ImeOsebe(u);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Insert.Enabled = false;
            if (richTextBox2.Text == "Opis")
                richTextBox2.Clear();

            Btn_Insert_L.Enabled = false;
            Btn_Delete_L.Enabled = true;
            Btn_Update_L.Enabled = true;

            if(listBox2.SelectedIndex >= 0)
            {
                string allData = listBox2.Items[listBox2.SelectedIndex].ToString();
                string[] data = allData.Split('|');

                textBox7.Text = data[0];
                comboBox3.Text = data[1];
                comboBox4.Text = data[2];
                textBox7.ReadOnly = true;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT l.opis FROM lokalni_studiji l INNER JOIN kraji k ON l.kraj_id = k.id INNER JOIN radijske_postaje rp ON l.radijska_postaja_id = rp.id WHERE (k.ime = '" + comboBox3.Text + "') AND (rp.naslov = '" + comboBox4.Text + "') AND (l.opis IS NOT NULL)", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Opis_l = reader.GetString(0);
                            Opis_L(Opis_l);
                            richTextBox2.Text = Opis_l;
                        }
                    }
                    else if (!reader.HasRows)
                    {
                        richTextBox2.Clear();
                    }
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT l.id FROM lokalni_studiji l INNER JOIN kraji k ON l.kraj_id = k.id INNER JOIN radijske_postaje rp ON l.radijska_postaja_id = rp.id WHERE (k.ime = '" + comboBox3.Text + "') AND (rp.naslov = '" + comboBox4.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        IDstudija(ID);
                    }
                    con.Close();
                }
            }
        }

        private void richTextBox2_Click(object sender, EventArgs e)
        {
            if(richTextBox2.Text == "Opis")
            {
                richTextBox2.Clear();
            }
            
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            if(richTextBox2.Text == "")
            {
                richTextBox2.Text = "Opis";
            }
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "")
            {
                richTextBox2.Text = "Opis";
            }
        }

        private void Btn_Odjava_L_Click(object sender, EventArgs e)
        {
            u = "";
            Form1.ImeOsebe(u);
            Lbl_User_L.Text = "Niste prijavljeni";
            Lbl_User.Text = "Niste prijavljeni";

            Btn_Odjava_L.Visible = false;
            Btn_Prijava_L.Visible = true;
            Btn_Reg_L.Visible = true;

            Btn_Odjava.Visible = false;
            Btn_Prijava.Visible = true;
            Btn_Reg.Visible = true;
        }

        private void Btn_Prijava_L_Click(object sender, EventArgs e)
        {
            b = new Form4();
            Hide();
            b.Show();
            Btn_Odjava_L.Visible = true;
            Btn_Prijava_L.Visible = false;
            Btn_Reg_L.Visible = false;
        }

        private void Btn_Reg_L_Click(object sender, EventArgs e)
        {
            c = new Form3();
            Hide();
            c.Show();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void Btn_Prijava_Click(object sender, EventArgs e)
        {
            b = new Form4();
            Hide();
            b.Show();
            Btn_Odjava.Visible = true;
            Btn_Prijava.Visible = false;
            Btn_Reg.Visible = false;
        }
    }
}
