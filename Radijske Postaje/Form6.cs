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
    public partial class Form6 : Form
    {
        Form1 a;
        static String f;
        static String f2;
        static String o;
        static String o2;
        public Form6()
        {
            InitializeComponent();
        }

        public static void Ozadje6(string o1)
        {
            if (o1 != null)
                o2 = o1;
        }

        public static void Pisava6(string f1)
        {
            if (f1 != null)
                f2 = f1;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Ozadje6(o2);
            Pisava6(f2);
            switch (f2)
            {
                case "Regular":
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label2.Font = new Font(label2.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    break;

                case "Bold":
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    label2.Font = new Font(label2.Font, FontStyle.Bold);
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    break;

                case "Italic":
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                    label2.Font = new Font(label2.Font, FontStyle.Italic);
                    label3.Font = new Font(label3.Font, FontStyle.Italic);
                    break;

                case "Underline":
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    label2.Font = new Font(label2.Font, FontStyle.Underline);
                    label3.Font = new Font(label3.Font, FontStyle.Underline);
                    break;
            }

            switch (o2)
            {
                case "Pink":
                    BackColor = Color.HotPink;
                    break;

                case "Bela":
                    BackColor = Control.DefaultBackColor;
                    break;

                case "Oranžna":
                    BackColor = Color.Orange;
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;
                    break;
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_fonte()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string font = reader.GetString(0);
                    comboBox1.Text = font;
                    comboBox1.Items.Add(font);
                    //f = font;
                    //Form1.Pisava(f);
                }
                con.Close();
            }

            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_barve_ozadja()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ozadje = reader.GetString(0);
                    comboBox2.Items.Add(ozadje);
                    comboBox2.Text = ozadje;
                    //o = ozadje;
                    //Form1.Ozadje(o);
                }
                con.Close();
            }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "Regular":
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label2.Font = new Font(label2.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    f = Convert.ToString(comboBox1.SelectedItem);
                    Form1.Pisava(f);
                    break;

                case "Bold":
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    label2.Font = new Font(label2.Font, FontStyle.Bold);
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    f = Convert.ToString(comboBox1.SelectedItem);
                    Form1.Pisava(f);
                    break;

                case "Italic":
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                    label2.Font = new Font(label2.Font, FontStyle.Italic);
                    label3.Font = new Font(label3.Font, FontStyle.Italic);
                    f = Convert.ToString(comboBox1.SelectedItem);
                    Form1.Pisava(f);
                    break;

                case "Underline":
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    label2.Font = new Font(label2.Font, FontStyle.Underline);
                    label3.Font = new Font(label3.Font, FontStyle.Underline);
                    f = Convert.ToString(comboBox1.SelectedItem);
                    Form1.Pisava(f);
                    break;
            }
            
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (Convert.ToString(comboBox2.SelectedItem))
            {
                case "Pink":
                    BackColor = Color.HotPink;
                    o = Convert.ToString(comboBox2.SelectedItem);
                    Form1.Ozadje(o);
                    break;

                case "Bela":
                    BackColor = Control.DefaultBackColor;
                    o = Convert.ToString(comboBox2.SelectedItem);
                    Form1.Ozadje(o);
                    break;

                case "Oranžna":
                    BackColor = Color.Orange;
                    o = Convert.ToString(comboBox2.SelectedItem);
                    Form1.Ozadje(o);
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;
                    o = Convert.ToString(comboBox2.SelectedItem);
                    Form1.Ozadje(o);
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == null)
                a = new Form1();

            a.Show();
            Hide();
            //Form1.Ozadje(o);
            //Form1.Pisava(f);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //read only
            e.SuppressKeyPress = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //read only
            e.SuppressKeyPress = true;
        }
    }
}
