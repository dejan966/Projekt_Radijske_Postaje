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
    public partial class Form1 : Form
    {
        
        static String mail;
        static String n;
        static String m;
        Form3 a;
        Form4 b;
        Form2 c;
        Form6 d;
        public Form1()
        {
            InitializeComponent(); 
        }

        

        public static void ImeOsebe(String n1)
        {
            mail = n1;
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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Niste prijavljeni";
            n = "";
            m = "";
            Form2.User(n, m);
            Btn_Reg.Visible = true;
            Btn_Login.Visible = true;
            button1.Visible = false;
        }

        private void Btn_Urejanje_Click(object sender, EventArgs e)
        {
            c = new Form2();
            Hide();
            c.Show();
            Form2.User(n, m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImeOsebe(mail);
            if (mail != null && mail != "")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM vrni_ime_priimek ('" + mail + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string ime = reader.GetString(0);
                        string priimek = reader.GetString(1);
                        label2.Text = "Prijavljeni ste kot " + ime + " " + priimek;
                        if (ime != null && priimek != null)
                        {
                            Form2.User(ime, priimek);
                            Form2.Mail(mail);
                        }

                    }

                    con.Close();
                }
                button1.Visible = true;
                Btn_Reg.Visible = false;
                Btn_Login.Visible = false;
            }
            
            else if(mail is null || mail=="")
            {
                label2.Text = "Niste prijavljeni";
                n = "";
                m = "";
                Form2.User(n, m);
                button1.Visible = false;
                Btn_Reg.Visible = true;
                Btn_Login.Visible = true;
            }
            else
            {
                button1.Visible = false;
                Btn_Reg.Visible = false;
                Btn_Login.Visible = false;
            }   
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            d = new Form6();
            Hide();
            d.Show();
        }
    }
}
