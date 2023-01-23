using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;


namespace otoparkyunus
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=otoparkyunusql.accdb");

        private void Button1_Click(object sender, EventArgs e)
        {
            Kayit kk = new Kayit();
            kk.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Gecmis gg = new Gecmis();
            gg.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Araccikis aa = new Araccikis();
            aa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Konum kk= new Konum();
            kk.Show();
        }
    }
        }