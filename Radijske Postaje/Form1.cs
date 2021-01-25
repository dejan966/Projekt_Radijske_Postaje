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
        static String o1;
        static String o2;
        static String f1;
        static String f2;

        Form3 a;
        Form4 b;
        Form2 c;
        Form6 d;
        public Form1()
        {
            InitializeComponent(); 
        }

        public static void Ozadje(string o1)
        {
            if(o1 != null)
                o2 = o1;
        }

        public static void Pisava(string f1)
        {
            if (f1 != null)
                f2 = f1;
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
            Pisava(f2);
            switch (f2)
            {
                case "Regular":
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label2.Font = new Font(label2.Font, FontStyle.Regular);
                    f1 = f2;
                    Form6.Pisava6(f1);
                    break;

                case "Bold":
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    label2.Font = new Font(label2.Font, FontStyle.Bold);
                    f1 = f2;
                    Form6.Pisava6(f1);
                    break;

                case "Italic":
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                    label2.Font = new Font(label2.Font, FontStyle.Italic);
                    f1 = f2;
                    Form6.Pisava6(f1);
                    break;

                case "Underline":
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    label2.Font = new Font(label2.Font, FontStyle.Underline);
                    f1 = f2;
                    Form6.Pisava6(f1);
                    break;
            }

            Ozadje(o2);
            switch (o2)
            {
                case "Rdeča":
                    BackColor = Color.Red;
                    o1 = o2;
                    Form6.Ozadje6(o1);
                    break;

                case "Bela":
                    BackColor = Control.DefaultBackColor;
                    o1 = o2;
                    Form6.Ozadje6(o1);
                    break;

                case "Oranžna":
                    BackColor = Color.Orange;
                    o1 = o2;
                    Form6.Ozadje6(o1);
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;
                    o1 = o2;
                    Form6.Ozadje6(o1);
                    break;
            }

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
