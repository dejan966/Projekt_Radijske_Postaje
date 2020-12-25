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
        string a = "Naslov";
        string b = "Opis";
        string c = "Frekvenca";
        string d = "Jezik";
        string j = "Spletna stran";
        string f = "Youtube";
        string g = "Twitter";
        string h = "Zvrst";
        string i = "Regija";
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = a;
        }
    }
}
