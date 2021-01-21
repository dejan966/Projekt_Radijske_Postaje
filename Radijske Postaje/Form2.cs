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
        int id_k;
        int id_rg;
        int id_z;

        List<string> postaje = new List<string>();
        List<string> studiji = new List<string>();
        List<string> kraji = new List<string>();
        List<string> regije = new List<string>();
        List<string> zvrsti = new List<string>();
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

        public void IDkraja(int z)
        {
            id_k = z;
        }

        public void IDregije(int t)
        {
            id_rg = t;
        }

        public void IDzvrsti(int u)
        {
            id_z = u;
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
                if (textBox1.Text == "Naslov" || textBox2.Text == "Frekvenca" || textBox3.Text == "Jezik")
                {
                    MessageBox.Show("Morate vnesti vsaj to kar je označeno z zvezdico");
                }
                else if(textBox1.Text != "Naslov" || textBox2.Text != "Frekvenca" || textBox3.Text != "Jezik")
                {
                    string opis = richTextBox1.Text;
                    string stran = textBox4.Text;
                    string yt = textBox5.Text;
                    string tw = textBox6.Text;

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM insertanje_postaj ('" + naslov + "', '" + opis + "', '" + frekvenca + "', '" + jezik + "', '" + stran + "', '" + yt + "', '" + tw + "', '" + zvrst + "', '" + regija + "')", con);

                        com.ExecuteNonQuery();
                        con.Close();
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
            Btn_Odjava_K.Visible = false;
            Btn_Odjava_R.Visible = false;
            Btn_Odjava_Z.Visible = false;

            Btn_Prijava.Visible = false;
            Btn_Prijava_L.Visible = false;
            Btn_Prijava_K.Visible = false;
            Btn_Prijava_R.Visible = false;
            Btn_Prijava_Z.Visible = false;

            Btn_Reg.Visible = false;
            Btn_Reg_L.Visible = false;
            Btn_Reg_K.Visible = false;
            Btn_Reg_R.Visible = false;
            Btn_Reg_Z.Visible = false;

            //label1.Font.Bold.ToString();
            comboBox1.Text = "rock";
            comboBox2.Text = "Gorenjska";
            comboBox3.Text = "Adlešiči";
            //comboBox4.Text = "";

            User(Ime, Priimek);
            if (Ime == null && Priimek == null || Ime == "" && Priimek == "")
            {
                Lbl_User.Text = "Niste prijavljeni";
                Lbl_User_L.Text = "Niste prijavljeni";
                Lbl_User_K.Text = "Niste prijavljeni";
                Lbl_User_R.Text = "Niste prijavljeni";
                Lbl_User_Z.Text = "Niste prijavljeni";

                u = "";
                Form1.ImeOsebe(u);
            }
            else if (Ime != null && Priimek != null || Ime != "" && Priimek != "")
            {
                Lbl_User.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;
                Lbl_User_L.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;
                Lbl_User_K.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;
                Lbl_User_R.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;
                Lbl_User_Z.Text = "Prijavljeni ste kot " + Ime + " " + Priimek;

                Btn_Odjava.Visible = true;
                Btn_Odjava_L.Visible = true;
                Btn_Odjava_K.Visible = true;
                Btn_Odjava_R.Visible = true;
                Btn_Odjava_Z.Visible = true;
            }
            if (Lbl_User.Text == "Niste prijavljeni" && Lbl_User_L.Text=="Niste prijavljeni" && Lbl_User_K.Text == "Niste prijavljeni" && Lbl_User_R.Text == "Niste prijavljeni" && Lbl_User_Z.Text == "Niste prijavljeni")
            {
                Btn_Prijava.Visible = true;
                Btn_Prijava_L.Visible = true;
                Btn_Prijava_K.Visible = true;
                Btn_Prijava_R.Visible = true;
                Btn_Prijava_Z.Visible = true;

                Btn_Reg.Visible = true;
                Btn_Reg_L.Visible = true;
                Btn_Reg_K.Visible = true;
                Btn_Reg_R.Visible = true;
                Btn_Reg_Z.Visible = true;

                u = "";
                Form1.ImeOsebe(u);
            }

            else if (Lbl_User.Text == "Prijavljeni ste kot " + Ime + " " + Priimek && Lbl_User_L.Text == "Prijavljeni ste kot " + Ime + " " + Priimek && Lbl_User_K.Text == "Prijavljeni ste kot " + Ime + " " + Priimek && Lbl_User_R.Text == "Prijavljeni ste kot " + Ime + " " + Priimek && Lbl_User_Z.Text == "Prijavljeni ste kot " + Ime + " " + Priimek)
            {
                Btn_Odjava_L.Visible = true;
                Btn_Odjava.Visible = true;
                Btn_Odjava_K.Visible = true;
                Btn_Odjava_R.Visible = true;
                Btn_Odjava_Z.Visible = true;
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_postaje()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string naslov = reader.GetString(0);
                    string frekvenca = reader.GetString(1);
                    string jezik = reader.GetString(2);
                    string z_ime = reader.GetString(3);
                    string r_ime = reader.GetString(4);
                    
                    comboBox4.Items.Add(naslov);
                    comboBox4.Text = naslov;

                    postaje.Add(naslov + '|' + frekvenca + '|' + jezik + '|' + z_ime + '|' + r_ime);
                    listBox1.Items.Clear();
                    foreach (string item in postaje)
                    {
                        listBox1.Items.Add(item);
                    }
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {

                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int posta = reader.GetInt32(0);
                    string ime = reader.GetString(1);
                    comboBox3.Items.Add(ime);
                    
                    //mal še poglej
                    kraji.Add(posta + '|' + ime);
                    listBox3.Items.Clear();
                    foreach (string item in kraji)
                    {
                        listBox3.Items.Add(item);
                    }
                }
                con.Close();

            }

            using (NpgsqlConnection con2 = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con2.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_zvrsti()", con2);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    comboBox1.Items.Add(ime);
                    zvrsti.Add(ime);
                    listBox5.Items.Clear();
                    foreach (string item in zvrsti)
                    {
                        listBox5.Items.Add(item);
                    }
                }
                
                con2.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_regije()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string regija = reader.GetString(0);
                    comboBox2.Items.Add(regija);
                    regije.Add(regija);
                    listBox4.Items.Clear();
                    foreach (string item in regije)
                    {
                        listBox4.Items.Add(item);
                    }
                }
                
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM list_studijev()", con);
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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_id_postaje ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_opis_postaj('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            string opis = reader.GetString(0);
                            if(opis != "")
                            {
                                Opis(opis);
                                richTextBox1.Text = opis;
                            }
                            else if(opis == "")
                            {
                                richTextBox1.Clear();
                            }
                        }
                    }
                    
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_stran_postaj('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string stran = reader.GetString(0);
                            if(stran != "")
                            {
                                splStran(stran);
                                textBox4.Text = stran;
                            }
                            else if(stran == "")
                            {
                                textBox4.Clear();
                            }
                        }
                    }
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_yt_postaj('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string yt = reader.GetString(0);
                            if(yt != "")
                            {
                                YT(yt);
                                textBox5.Text = yt;
                            }
                            else if(yt == "")
                            {
                                textBox5.Clear();
                            }
                        }
                    }
                    
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_tw_postaj('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string twitter = reader.GetString(0);
                            if(twitter != "")
                            {
                                TW(twitter);
                                textBox6.Text = twitter;
                            }
                            else if(twitter == "")
                            {
                                textBox6.Clear();
                            }
                            
                        }
                    }
                    con.Close();
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
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
                    Btn_Update.Enabled = false;
                    Btn_Delete.Enabled = false;
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;

                    IDpostaje(id_r);

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com2 = new NpgsqlCommand("SELECT * FROM updatanje_postaj ('" + id_r + "', '" + richTextBox1.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
                        com2.ExecuteNonQuery();
                        con.Close();
                    }

                    

                    listBox1.SetSelected(i, false);
                    /* problem pri itemu ko je cist zgori
                       da bodo ble spremembe vidne takoj v listboxu
                    int i = listBox1.SelectedIndex;
                    postaje.RemoveAt(i);
                    listBox1.Items.Clear();
                    postaje.Add(textBox1.Text + '|' + textBox2.Text + '|' + textBox3.Text + '|' + comboBox1.Text + '|' + comboBox2.Text);
                    foreach (string item in postaje)
                    {
                        listBox1.Items.Add(item);
                    }*/

                    richTextBox1.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    

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

                    listBox1.SetSelected(i, false);
                    Btn_Insert.Enabled = true;
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;

                    IDpostaje(id_r);

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT  * FROM deletanje_studijev ('" + id_r + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        
                        if (reader.HasRows)
                        {                          
                            while (reader.Read())
                            {
                                string Lime = reader.GetString(0);
                                string Kime = reader.GetString(1);
                                string Pime = reader.GetString(2);

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
                                }
                                
                            }
                        }
                        
                        con.Close();
                    }

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_postaj ('" + id_r + "' )", con);
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
            Lbl_User_K.Text = "Niste prijavljeni";
            Lbl_User_R.Text = "Niste prijavljeni";
            Lbl_User_Z.Text = "Niste prijavljeni";

            Btn_Odjava.Visible = false;
            Btn_Odjava_L.Visible = false;
            Btn_Odjava_K.Visible = false;
            Btn_Odjava_R.Visible = false;
            Btn_Odjava_Z.Visible = false;

            Btn_Prijava.Visible = true;
            Btn_Prijava_L.Visible = true;
            Btn_Prijava_K.Visible = true;
            Btn_Prijava_R.Visible = true;
            Btn_Prijava_Z.Visible = true;

            Btn_Reg.Visible = true;
            Btn_Reg_L.Visible = true;
            Btn_Reg_K.Visible = true;
            Btn_Reg_R.Visible = true;
            Btn_Reg_Z.Visible = true;
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            c = new Form3();
            Hide();
            c.Show();
        }

        private void Btn_Insert_L_Click(object sender, EventArgs e)
        {
            
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
                    string s_ime = textBox7.Text;
                    string s_opis = richTextBox2.Text;
                    string kraj = comboBox3.Text;
                    string r_postaja = comboBox4.Text;
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM insertanje_studijev('" + s_ime + "', '" + s_opis + "', '" + kraj + "','" + r_postaja + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();
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
            richTextBox2.Clear();
        }

        private void Btn_Update_L_Click(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex;
            //Opis_L(l_opis);
            IDstudija(id_l);
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                Btn_Insert_L.Enabled = true;
                Btn_Update_L.Enabled = false;
                Btn_Delete_L.Enabled = false;
                textBox7.ReadOnly = false;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM updatanje_studijev('" + id_l + "', '" + richTextBox2.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "') ", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                listBox2.SetSelected(i, false);
                /*int i = listBox1.SelectedIndex;
                 *da bodo ble spremembe vidne takoj v listboxu
                    postaje.RemoveAt(i);
                    listBox1.Items.Clear();
                    postaje.Add(textBox1.Text + '|' + textBox2.Text + '|' + textBox3.Text + '|' + comboBox1.Text + '|' + comboBox2.Text);
                    foreach (string item in postaje)
                    {
                        listBox1.Items.Add(item);
                    }*/

                textBox7.Clear();
                richTextBox2.Clear();
                
            }
                
        }

        private void Btn_Delete_L_Click(object sender, EventArgs e)
        {
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
                    Btn_Insert_L.Enabled = true;
                    Btn_Update_L.Enabled = false;
                    Btn_Delete_L.Enabled = false;
                    textBox7.ReadOnly = false;
                    listBox2.SetSelected(i, false);

                    IDstudija(id_l);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_studija('" + id_l + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    textBox7.Clear();
                    richTextBox2.Clear();
                    
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
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_opis_studijev ('" + textBox7.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string Opis_l = reader.GetString(0);
                            
                            if (Opis_l != "")
                            {
                                Opis_L(Opis_l);
                                richTextBox2.Text = Opis_l;
                            }
                            else if (Opis_l == "")
                            {
                                richTextBox2.Clear();
                            }
                        }
                    }
                    
                    con.Close();
                }

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_id_studija ('" + textBox7.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "')", con);
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

            Lbl_User.Text = "Niste prijavljeni";
            Lbl_User_L.Text = "Niste prijavljeni";
            Lbl_User_K.Text = "Niste prijavljeni";
            Lbl_User_R.Text = "Niste prijavljeni";
            Lbl_User_Z.Text = "Niste prijavljeni";

            Btn_Odjava.Visible = false;
            Btn_Odjava_L.Visible = false;
            Btn_Odjava_K.Visible = false;
            Btn_Odjava_R.Visible = false;
            Btn_Odjava_Z.Visible = false;

            Btn_Prijava.Visible = true;
            Btn_Prijava_L.Visible = true;
            Btn_Prijava_K.Visible = true;
            Btn_Prijava_R.Visible = true;
            Btn_Prijava_Z.Visible = true;

            Btn_Reg.Visible = true;
            Btn_Reg_L.Visible = true;
            Btn_Reg_K.Visible = true;
            Btn_Reg_R.Visible = true;
            Btn_Reg_Z.Visible = true;
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
            if(textBox7.Text == "Ime")
                textBox7.Clear();
        }

        private void Btn_Insert_K_Click(object sender, EventArgs e)
        {
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                int posta = Convert.ToInt32(textBox8.Text);
                string ime = textBox9.Text;
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM insertanje_krajev('" + posta + "', '" + ime + "')", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                textBox8.Clear();
                textBox9.Clear();

                kraji.Add(posta + '|' + ime);
                listBox3.Items.Clear();
                foreach (string item in kraji)
                {
                    listBox3.Items.Add(item);
                }
            }
        }

        private void Btn_Update_K_Click(object sender, EventArgs e)
        {
            int i = listBox3.SelectedIndex;
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                IDkraja(id_k);
                string posta = Convert.ToString(textBox8.Text);
                string ime = textBox9.Text;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM updatanje_krajev('" + id_k + "', '" + posta + "', '" + ime + "') ", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                listBox3.SetSelected(i, false);
                /* da bodo ble spremembe vidne takoj v listboxu
                 int i = listBox1.SelectedIndex;
                        postaje.RemoveAt(i);
                        listBox1.Items.Clear();
                        postaje.Add(textBox1.Text + '|' + textBox2.Text + '|' + textBox3.Text + '|' + comboBox1.Text + '|' + comboBox2.Text);
                        foreach (string item in postaje)
                        {
                            listBox1.Items.Add(item);
                        }*/
                textBox8.Clear();
                textBox9.Clear();

                Btn_Insert_K.Enabled = true;
                Btn_Update_K.Enabled = false;
                Btn_Delete_K.Enabled = false;
            }


        }

        private void Btn_Delete_K_Click(object sender, EventArgs e)
        {
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                if (listBox3.SelectedIndex >= 0)
                {
                    Btn_Insert_K.Enabled = true;
                    Btn_Update_K.Enabled = false;
                    Btn_Delete_K.Enabled = false;

                    IDkraja(id_k);
                    int i = listBox3.SelectedIndex;
                    kraji.RemoveAt(i);
                    listBox3.Items.Clear();
                    foreach (string item in kraji)
                    {
                        listBox3.Items.Add(item);
                    }
                    listBox3.SetSelected(i, false);

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_kraja('" + id_k + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string Lime = reader.GetString(0);
                                string Kime = reader.GetString(1);
                                string Pime = reader.GetString(2);

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
                                }
                            }
                        }
                        con.Close();
                    }

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_krajev('" + id_k + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    textBox8.Clear();
                    textBox9.Clear();
                }
            }
        }

        private void Btn_Reg_K_Click(object sender, EventArgs e)
        {
            c = new Form3();
            Hide();
            c.Show();
        }

        private void Btn_Prijava_K_Click(object sender, EventArgs e)
        {
            b = new Form4();
            Hide();
            b.Show();

            Btn_Odjava_K.Visible = true;
            Btn_Prijava_K.Visible = false;
            Btn_Reg_K.Visible = false;
        }

        private void Btn_Odjava_K_Click(object sender, EventArgs e)
        {
            u = "";
            Form1.ImeOsebe(u);

            Lbl_User.Text = "Niste prijavljeni";
            Lbl_User_L.Text = "Niste prijavljeni";
            Lbl_User_K.Text = "Niste prijavljeni";
            Lbl_User_R.Text = "Niste prijavljeni";
            Lbl_User_Z.Text = "Niste prijavljeni";

            Btn_Odjava.Visible = false;
            Btn_Odjava_L.Visible = false;
            Btn_Odjava_K.Visible = false;
            Btn_Odjava_R.Visible = false;
            Btn_Odjava_Z.Visible = false;

            Btn_Prijava.Visible = true;
            Btn_Prijava_L.Visible = true;
            Btn_Prijava_K.Visible = true;
            Btn_Prijava_R.Visible = true;
            Btn_Prijava_Z.Visible = true;

            Btn_Reg.Visible = true;
            Btn_Reg_L.Visible = true;
            Btn_Reg_K.Visible = true;
            Btn_Reg_R.Visible = true;
            Btn_Reg_Z.Visible = true;
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            if(textBox10.Text == "Ime")
                textBox10.Clear();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
                textBox9.Text = "Ime";

            textBox8.Clear();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if(textBox8.Text == "")
                textBox8.Text = "Pošta";
            
            textBox9.Clear();
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "Ime")
                textBox11.Clear();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Insert_K.Enabled = false;
            Btn_Update_K.Enabled = true;
            Btn_Delete_K.Enabled = true;
            if (listBox3.SelectedIndex >= 0)
            {
                string allData = listBox3.Items[listBox3.SelectedIndex].ToString();
                string[] data = allData.Split('|');
                textBox8.Text = data[0];
                textBox9.Text = data[1];
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_id_krajev ('" + textBox8.Text + "', '" + textBox9.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        IDkraja(id);
                    }
                    con.Close();
                }
            }
                
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Insert_R.Enabled = false;
            Btn_Update_R.Enabled = true;
            Btn_Delete_R.Enabled = true;
            if (listBox4.SelectedIndex >= 0)
            {
                textBox10.Text = listBox4.Items[listBox4.SelectedIndex].ToString();
                /*string[] data = allData.Split();
                textBox10.Text = data[0];*/
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_id_regij ('" + textBox10.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        IDregije(id);
                    }
                    con.Close();
                }
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Insert_Z.Enabled = false;
            Btn_Update_Z.Enabled = true;
            Btn_Delete_Z.Enabled = true;
            if (listBox5.SelectedIndex >= 0)
            {
                textBox11.Text = listBox5.Items[listBox5.SelectedIndex].ToString();
                /*string[] data = allData.Split();
                textBox11.Text = data[0];*/
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_id_zvrsti ('" + textBox11.Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        IDzvrsti(id);
                    }
                    con.Close();
                }
            }
        }

        private void Btn_Insert_R_Click(object sender, EventArgs e)
        {
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                string ime = textBox10.Text;

                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM insertanje_regije('" + ime +"')", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }

                regije.Add(ime);
                listBox4.Items.Clear();
                foreach (string item in regije)
                {
                    listBox4.Items.Add(item);
                }
                textBox10.Clear();
            }
        }

        private void Btn_Update_R_Click(object sender, EventArgs e)
        {
            int i = listBox4.SelectedIndex;
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                string ime = textBox10.Text;
                IDregije(id_rg);
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM updatanje_regije('" + id_rg + "', '" + ime + "')", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                listBox4.SetSelected(i, false);
                /* da bodo ble spremembe vidne takoj v listboxu
                 int i = listBox1.SelectedIndex;
                        postaje.RemoveAt(i);
                        listBox1.Items.Clear();
                        postaje.Add(textBox1.Text + '|' + textBox2.Text + '|' + textBox3.Text + '|' + comboBox1.Text + '|' + comboBox2.Text);
                        foreach (string item in postaje)
                        {
                            listBox1.Items.Add(item);
                        }*/
                Btn_Insert_R.Enabled = true;
                Btn_Update_R.Enabled = false;
                Btn_Delete_R.Enabled = false;
                textBox10.Clear();
            }

        }

        private void Btn_Delete_R_Click(object sender, EventArgs e)
        {
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                if (listBox4.SelectedIndex >= 0)
                {
                    Btn_Insert_R.Enabled = true;
                    Btn_Update_R.Enabled = false;
                    Btn_Delete_R.Enabled = false;

                    IDregije(id_rg);
                    int i = listBox4.SelectedIndex;
                    regije.RemoveAt(i);
                    listBox4.Items.Clear();
                    foreach (string item in regije)
                    {
                        listBox4.Items.Add(item);
                    }
                    listBox4.SetSelected(i, false);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_regij('" + id_rg + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string naslov = reader.GetString(0);
                                string frekvenca = reader.GetString(1);
                                string jezik = reader.GetString(2);
                                string z_ime = reader.GetString(3);
                                string r_ime = reader.GetString(4);

                                string skupaj = naslov + '|' + frekvenca + '|' + jezik + '|' + z_ime + '|' + r_ime;

                                var postaja = postaje.Single(r => r.Equals(skupaj));

                                if (postaja != null)
                                {
                                    postaje.Remove(postaja);

                                    listBox1.Items.Clear();
                                    foreach (string item in postaje)
                                    {
                                        listBox1.Items.Add(item);
                                    }
                                }
                                
                            }
                        }
                        con.Close();
                    }

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_regije('" + id_rg + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    textBox10.Clear();
                }
            }
        }

        private void Btn_Reg_R_Click(object sender, EventArgs e)
        {
            c = new Form3();
            Hide();
            c.Show();
        }

        private void Btn_Prijava_R_Click(object sender, EventArgs e)
        {
            b = new Form4();
            Hide();
            b.Show();

            Btn_Odjava_R.Visible = true;
            Btn_Prijava_R.Visible = false;
            Btn_Reg_R.Visible = false;
        }

        private void Btn_Odjava_R_Click(object sender, EventArgs e)
        {
            u = "";
            Form1.ImeOsebe(u);

            Lbl_User.Text = "Niste prijavljeni";
            Lbl_User_L.Text = "Niste prijavljeni";
            Lbl_User_K.Text = "Niste prijavljeni";
            Lbl_User_R.Text = "Niste prijavljeni";
            Lbl_User_Z.Text = "Niste prijavljeni";

            Btn_Odjava.Visible = false;
            Btn_Odjava_L.Visible = false;
            Btn_Odjava_K.Visible = false;
            Btn_Odjava_R.Visible = false;
            Btn_Odjava_Z.Visible = false;

            Btn_Prijava.Visible = true;
            Btn_Prijava_L.Visible = true;
            Btn_Prijava_K.Visible = true;
            Btn_Prijava_R.Visible = true;
            Btn_Prijava_Z.Visible = true;

            Btn_Reg.Visible = true;
            Btn_Reg_L.Visible = true;
            Btn_Reg_K.Visible = true;
            Btn_Reg_R.Visible = true;
            Btn_Reg_Z.Visible = true;
        }

        private void Btn_Reg_Z_Click(object sender, EventArgs e)
        {
            c = new Form3();
            Hide();
            c.Show();
        }

        private void Btn_Insert_Z_Click(object sender, EventArgs e)
        {
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                string ime = textBox11.Text;
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM insertanje_zvrsti('" + ime + "')", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }

                zvrsti.Add(ime);
                listBox5.Items.Clear();
                foreach (string item in zvrsti)
                {
                    listBox5.Items.Add(item);
                }

                textBox11.Clear();
            }
        }

        private void Btn_Update_Z_Click(object sender, EventArgs e)
        {
            int i = listBox5.SelectedIndex;
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                string ime = textBox11.Text;
                IDzvrsti(id_z);
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM updatanje_zvrsti('" + id_z + "', '" + ime + "')", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                listBox5.SetSelected(i, false);
                /* da bodo ble spremembe vidne takoj v listboxu 
                   int i = listBox1.SelectedIndex;
                        postaje.RemoveAt(i);
                        listBox1.Items.Clear();
                        postaje.Add(textBox1.Text + '|' + textBox2.Text + '|' + textBox3.Text + '|' + comboBox1.Text + '|' + comboBox2.Text);
                        foreach (string item in postaje)
                        {
                            listBox1.Items.Add(item);
                        }*/
                textBox11.Clear();

                Btn_Insert_Z.Enabled = true;
                Btn_Update_Z.Enabled = false;
                Btn_Delete_Z.Enabled = false;
            }
        }

        private void Btn_Delete_Z_Click(object sender, EventArgs e)
        {
            if (Lbl_User_L.Text == "Niste prijavljeni")
            {
                MessageBox.Show("Morate biti prijavljeni");
            }
            else if (Lbl_User_L.Text != "Niste prijavljeni")
            {
                if(listBox5.SelectedIndex >= 0)
                {
                    IDzvrsti(id_z);
                    int i = listBox5.SelectedIndex;
                    zvrsti.RemoveAt(i);
                    listBox5.Items.Clear();
                    foreach (string item in zvrsti)
                    {
                        listBox5.Items.Add(item);
                    }
                    listBox5.SetSelected(i, false);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_vrste('" + id_z + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string naslov = reader.GetString(0);
                                string frekvenca = reader.GetString(1);
                                string jezik = reader.GetString(2);
                                string z_ime = reader.GetString(3);
                                string r_ime = reader.GetString(4);

                                string skupaj = naslov + '|' + frekvenca + '|' + jezik + '|' + z_ime + '|' + r_ime;

                                var postaja = postaje.Single(r => r.Equals(skupaj));

                                if (postaja != null)
                                {
                                    postaje.Remove(postaja);

                                    listBox1.Items.Clear();
                                    foreach (string item in postaje)
                                    {
                                        listBox1.Items.Add(item);
                                    }
                                }
                            }
                        }
                        con.Close();
                    }

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM deletanje_zvrsti('" + id_z + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();
                    }

                    Btn_Insert_Z.Enabled = true;
                    Btn_Update_Z.Enabled = false;
                    Btn_Delete_Z.Enabled = false;

                    textBox11.Clear();
                }
            }                          
        }

        private void Btn_Prijava_Z_Click(object sender, EventArgs e)
        {
            b = new Form4();
            Hide();
            b.Show();

            Btn_Odjava_Z.Visible = true;
            Btn_Prijava_Z.Visible = false;
            Btn_Reg_Z.Visible = false;
        }

        private void Btn_Odjava_Z_Click(object sender, EventArgs e)
        {
            u = "";
            Form1.ImeOsebe(u);

            Lbl_User.Text = "Niste prijavljeni";
            Lbl_User_L.Text = "Niste prijavljeni";
            Lbl_User_K.Text = "Niste prijavljeni";
            Lbl_User_R.Text = "Niste prijavljeni";
            Lbl_User_Z.Text = "Niste prijavljeni";

            Btn_Odjava.Visible = false;
            Btn_Odjava_L.Visible = false;
            Btn_Odjava_K.Visible = false;
            Btn_Odjava_R.Visible = false;
            Btn_Odjava_Z.Visible = false;

            Btn_Prijava.Visible = true;
            Btn_Prijava_L.Visible = true;
            Btn_Prijava_K.Visible = true;
            Btn_Prijava_R.Visible = true;
            Btn_Prijava_Z.Visible = true;

            Btn_Reg.Visible = true;
            Btn_Reg_L.Visible = true;
            Btn_Reg_K.Visible = true;
            Btn_Reg_R.Visible = true;
            Btn_Reg_Z.Visible = true;
        }

        private void Btn_Bck_K_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();

            Form1.ImeOsebe(u);
        }

        private void Btn_Bck_R_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();

            Form1.ImeOsebe(u);
        }

        private void Btn_Bck_Z_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();

            Form1.ImeOsebe(u);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Naslov";

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

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Naslov";

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
