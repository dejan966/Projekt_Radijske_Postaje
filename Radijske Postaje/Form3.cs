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
    public partial class Form3 : Form
    {
        Form1 a;
        Form4 b;

        static String o3;
        static String f3;
        public Form3()
        {
            InitializeComponent();
        }

        public static void Ozadje3(string o)
        {
            if (o != null)
                o3 = o;
        }

        public static void Pisava3(string f)
        {
            if (f != null)
                f3 = f;
        }

        public static string PassHash(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }

            return returnValue.ToString();
        }


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            a = new Form1();
            Hide();
            a.Show();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = textBox1.Text;
                string priimek = textBox2.Text;
                int starost = Convert.ToInt32(textBox3.Text);
                string mail = textBox4.Text;
                string pass = textBox5.Text;
                string kraj = comboBox1.Text;
                char spol;
                if (radioButton1.Checked)
                {
                    spol = 'M';
                    string hash = PassHash(pass);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM registracija('" + ime + "','" + priimek + "', '" + spol + "' , '" + starost + "' ,'" + mail + "', '" + hash + "' , '" + kraj + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string email = reader.GetString(0);
                                if (email == mail)
                                {
                                    MessageBox.Show("Uporabnik s tem mailom že obstaja");
                                }
                                else if(email != mail)
                                {
                                    b = new Form4();
                                    Hide();
                                    b.Show();
                                }
                            }
                            
                        }
                         
                           
                        con.Close();
                    }
                }
                    
                else if (radioButton2.Checked)
                {
                    spol = 'Ž';
                    string hash = PassHash(pass);
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
                    {

                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM reg_prijava ('" + ime + "','" + priimek + "', '" + spol + "' , '" + starost + "' ,'" + mail + "', '" + hash + "' , '" + kraj + "')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string email = reader.GetString(0);
                                if (email == mail)
                                {
                                    MessageBox.Show("Uporabnik s tem mailom že obstaja");
                                }
                            }

                        }
                        else if (!reader.HasRows)
                        {
                            b = new Form4();
                            Hide();
                            b.Show();
                        }
                        con.Close();
                    }
                }  
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Napaka v formatu: " + ex.Message);
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Pisava3(f3);
            switch (f3)
            {
                case "Regular":
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label2.Font = new Font(label2.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    label4.Font = new Font(label4.Font, FontStyle.Regular);
                    label5.Font = new Font(label5.Font, FontStyle.Regular);
                    label6.Font = new Font(label6.Font, FontStyle.Regular);
                    label7.Font = new Font(label7.Font, FontStyle.Regular);
                    label8.Font = new Font(label8.Font, FontStyle.Regular);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Regular);
                    comboBox1.Font = new Font(comboBox1.Font, FontStyle.Regular);
                    radioButton1.Font = new Font(radioButton1.Font, FontStyle.Regular);
                    radioButton2.Font = new Font(radioButton2.Font, FontStyle.Regular);

                    Form6.Pisava6(f3);
                    Form2.Pisava2(f3);
                    Form1.Pisava(f3);
                    Form4.Pisava4(f3);
                    break;

                case "Italic":
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                    label2.Font = new Font(label2.Font, FontStyle.Italic);
                    label3.Font = new Font(label3.Font, FontStyle.Italic);
                    label4.Font = new Font(label4.Font, FontStyle.Italic);
                    label5.Font = new Font(label5.Font, FontStyle.Italic);
                    label6.Font = new Font(label6.Font, FontStyle.Italic);
                    label7.Font = new Font(label7.Font, FontStyle.Italic);
                    label8.Font = new Font(label8.Font, FontStyle.Italic);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Italic);
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Italic);
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Italic);
                    comboBox1.Font = new Font(comboBox1.Font, FontStyle.Italic);
                    radioButton1.Font = new Font(radioButton1.Font, FontStyle.Italic);
                    radioButton2.Font = new Font(radioButton2.Font, FontStyle.Italic);

                    Form6.Pisava6(f3);
                    Form2.Pisava2(f3);
                    Form1.Pisava(f3);
                    Form4.Pisava4(f3);
                    break;

                case "Bold":
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    label2.Font = new Font(label2.Font, FontStyle.Bold);
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    label4.Font = new Font(label4.Font, FontStyle.Bold);
                    label5.Font = new Font(label5.Font, FontStyle.Bold);
                    label6.Font = new Font(label6.Font, FontStyle.Bold);
                    label7.Font = new Font(label7.Font, FontStyle.Bold);
                    label8.Font = new Font(label8.Font, FontStyle.Bold);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Bold);
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Bold);
                    comboBox1.Font = new Font(comboBox1.Font, FontStyle.Bold);
                    radioButton1.Font = new Font(radioButton1.Font, FontStyle.Bold);
                    radioButton2.Font = new Font(radioButton2.Font, FontStyle.Bold);

                    Form6.Pisava6(f3);
                    Form2.Pisava2(f3);
                    Form1.Pisava(f3);
                    Form4.Pisava4(f3);
                    break;

                case "Underline":
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    label2.Font = new Font(label2.Font, FontStyle.Underline);
                    label3.Font = new Font(label3.Font, FontStyle.Underline);
                    label4.Font = new Font(label4.Font, FontStyle.Underline);
                    label5.Font = new Font(label5.Font, FontStyle.Underline);
                    label6.Font = new Font(label6.Font, FontStyle.Underline);
                    label7.Font = new Font(label7.Font, FontStyle.Underline);
                    label8.Font = new Font(label8.Font, FontStyle.Underline);

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Underline);
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Underline);
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Underline);
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Underline);
                    comboBox1.Font = new Font(comboBox1.Font, FontStyle.Underline);
                    radioButton1.Font = new Font(radioButton1.Font, FontStyle.Underline);
                    radioButton2.Font = new Font(radioButton2.Font, FontStyle.Underline);

                    Form6.Pisava6(f3);
                    Form2.Pisava2(f3);
                    Form1.Pisava(f3);
                    Form4.Pisava4(f3);
                    break;
            }

            Ozadje3(o3);
            switch (o3)
            {
                case "Rdeča":
                    BackColor = Color.Red;
                    Form6.Ozadje6(o3);
                    Form2.Ozadje2(o3);
                    Form1.Ozadje(o3);
                    Form4.Ozadje4(o3);
                    break;

                case "Bela":
                    BackColor = Control.DefaultBackColor;
                    Form6.Ozadje6(o3);
                    Form2.Ozadje2(o3);
                    Form1.Ozadje(o3);
                    Form4.Ozadje4(o3);
                    break;

                case "Oranžna":
                    BackColor = Color.Orange;
                    Form6.Ozadje6(o3);
                    Form2.Ozadje2(o3);
                    Form1.Ozadje(o3);
                    Form4.Ozadje4(o3);
                    break;

                case "Rumena":
                    BackColor = Color.Yellow;
                    Form6.Ozadje6(o3);
                    Form2.Ozadje2(o3);
                    Form1.Ozadje(o3);
                    Form4.Ozadje4(o3);
                    break;
            }

            comboBox1.Text = "Adlešiči";
            using (NpgsqlConnection con = new NpgsqlConnection("Server=dumbo.db.elephantsql.com; User Id=ejdvbvlw;" + "Password=oLgUkOCXPTKG_2bvDFB1NnSPgp3tcDxj; Database=ejdvbvlw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    comboBox1.Items.Add(ime);
                }
                con.Close();
            }
        }
    }
}
