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
        string a = "Naslov";
        string b = "Opis";
        string c = "Frekvenca";
        string d = "Jezik";
        string j = "Spletna stran";
        string f = "Youtube";
        string g = "Twitter";
        string h = "Zvrst";
        string i = "Regija";
        public Form1()
        {
            InitializeComponent();            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {           
            textBox1.Clear();
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Clear();
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Clear();
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Clear();
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Clear();
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Clear();
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Clear();
            textBox7.Text = h;
            textBox8.Text = i;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Clear();
            textBox8.Text = i;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox1.Text = a;
            richTextBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = j;
            textBox5.Text = f;
            textBox6.Text = g;
            textBox7.Text = h;
            textBox8.Clear();
        }

        /*Testiranje
        void izpisi()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM zvrsti", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(1);
                    string opis = reader.GetString(2);

                    MessageBox.Show(ime + " " + opis);
                }
                
            }
        }*/


    }
}
