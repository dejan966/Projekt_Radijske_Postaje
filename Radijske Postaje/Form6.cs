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
        Form1 b;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
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
            
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (Convert.ToString(comboBox2.SelectedItem))
            {
                case "Rdeča":
                    BackColor = Color.Red;
                    break;

                case "Bela":
                    BackColor = Color.White;
                    break;

                case "Modra":
                    BackColor = Color.Blue;
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a = new Form1();
            Hide();
            a.Show();

            
        }
    }
}
