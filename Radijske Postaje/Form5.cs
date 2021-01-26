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
    public partial class Form5 : Form
    {
        Form4 a;

        static String mail;
        static String o5;
        static String f5;
        public Form5()
        {
            InitializeComponent();
        }

        public static void Ozadje5(string o)
        {
            if (o != null)
                o5 = o;
        }

        public static void Pisava5(string f)
        {
            if (f != null)
                f5 = f;
        }

        public static void Mail(String n2)
        {
            mail = n2;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string novoGeslo = textBox1.Text;
                string hash = Form3.PassHash(novoGeslo);
                using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                {
                    con.Open();

                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM new_pass ('" + mail + "' ,'" + hash + "')", con);
                    com.ExecuteNonQuery();

                    con.Close();
                }
                a = new Form4();
                a.Show();
                Hide();
            }
            else
                MessageBox.Show("Morate vnesti novo geslo");
            
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            a = new Form4();
            a.Show();
            Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Ozadje5(o5);
            Pisava5(f5);

            switch (f5)
            {
                case "Regular":
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    label1.Font = new Font(label1.Font, FontStyle.Regular);

                    Form4.Pisava4(f5);
                    break;

                case "Bold":
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    label1.Font = new Font(label1.Font, FontStyle.Bold);

                    Form4.Pisava4(f5);
                    break;

                case "Underline":
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                    label1.Font = new Font(label1.Font, FontStyle.Underline);

                    Form4.Pisava4(f5);
                    break;

                case "Italic":
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                    label1.Font = new Font(label1.Font, FontStyle.Italic);

                    Form4.Pisava4(f5);
                    break;
            }

            switch (o5)
            {
                case "Bela":
                    BackColor = Control.DefaultBackColor;

                    Form4.Ozadje4(o5);
                    break;

                case "Rdeča":
                    BackColor = Color.Red;

                    Form4.Ozadje4(o5);
                    break;

                case "Oranžna":
                    BackColor = Color.Orange;

                    Form4.Ozadje4(o5);
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;

                    Form4.Ozadje4(o5);
                    break;
            }
        }
    }
}
