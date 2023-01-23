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

namespace otoparkyunus
{
    public partial class Gecmis : Form
    {
        public Gecmis()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void Gecmis_Load(object sender, EventArgs e)
        {
            Anasayfa.baglanti.Open();
            tablo.Clear();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from gecmis", Anasayfa.baglanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Anasayfa.baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa.baglanti.Open();
            string sql = "SELECT * FROM gecmis Where gsaat  >= @tarih1 and gsaat < @tarih2";
            DataTable tablo = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql,Anasayfa.baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);
            adp.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value);
            adp.Fill(tablo);
            Anasayfa.baglanti.Close();
            dataGridView1.DataSource = tablo;
        }
        }
    }


