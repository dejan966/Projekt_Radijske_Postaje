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

        static String o4;
        static String f4;
        public Form4()
        {
            InitializeComponent();
        }


        public static void Ozadje4(string o)
        {
            if (o != null)
                o4 = o;
        }

        public static void Pisava4(string f)
        {
            if (f != null)
                f4 = f;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            Ozadje4(o4);
            Pisava4(f4);
            switch (f4)
            {
                case "Regular":
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    label4.Font = new Font(label4.Font, FontStyle.Regular);
                    Lbl_Pozabljeno_geslo.Font = new Font(Lbl_Pozabljeno_geslo.Font, FontStyle.Regular);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);

                    Form6.Pisava6(f4);
                    Form2.Pisava2(f4);
                    Form1.Pisava(f4);
                    Form5.Pisava5(f4);
                    break;

                case "Italic":
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                    label3.Font = new Font(label3.Font, FontStyle.Italic);
                    label4.Font = new Font(label4.Font, FontStyle.Italic);
                    Lbl_Pozabljeno_geslo.Font = new Font(Lbl_Pozabljeno_geslo.Font, FontStyle.Italic);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);

                    Form6.Pisava6(f4);
                    Form2.Pisava2(f4);
                    Form1.Pisava(f4);
                    Form5.Pisava5(f4);
                    break;

                case "Bold":
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    label4.Font = new Font(label4.Font, FontStyle.Bold);
                    Lbl_Pozabljeno_geslo.Font = new Font(Lbl_Pozabljeno_geslo.Font, FontStyle.Bold);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);

                    Form6.Pisava6(f4);
                    Form2.Pisava2(f4);
                    Form1.Pisava(f4);
                    Form5.Pisava5(f4);
                    break;

                case "Underline":
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    label3.Font = new Font(label3.Font, FontStyle.Underline);
                    label4.Font = new Font(label4.Font, FontStyle.Underline);
                    Lbl_Pozabljeno_geslo.Font = new Font(Lbl_Pozabljeno_geslo.Font, FontStyle.Underline);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Underline);

                    Form6.Pisava6(f4);
                    Form2.Pisava2(f4);
                    Form1.Pisava(f4);
                    Form5.Pisava5(f4);
                    break;
            }

            switch (o4)
            {
                case "Rdeča":
                    BackColor = Color.Red;
                    Form6.Ozadje6(o4);
                    Form2.Ozadje2(o4);
                    Form1.Ozadje(o4);
                    Form5.Ozadje5(o4);
                    break;

                case "Bela":
                    BackColor = Control.DefaultBackColor;
                    Form6.Ozadje6(o4);
                    Form2.Ozadje2(o4);
                    Form1.Ozadje(o4);
                    Form5.Ozadje5(o4);
                    break;

                case "Oranžna":
                    BackColor = Color.Orange;
                    Form6.Ozadje6(o4);
                    Form2.Ozadje2(o4);
                    Form1.Ozadje(o4);
                    Form5.Ozadje5(o4);
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;
                    Form6.Ozadje6(o4);
                    Form2.Ozadje2(o4);
                    Form1.Ozadje(o4);
                    Form5.Ozadje5(o4);
                    break;
            }

        }
    }
}
