using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace otoparkyunus
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            Anasayfa.baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from parkyeri where durum=0", Anasayfa.baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["parkyeri"].ToString());
            }
            Anasayfa.baglanti.Close();


    }
        private void Button1_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToString();
            Anasayfa.baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("Insert Into musteri (p,marka,model,plaka,adi,soyadi,gsaat,durum,aracyikama) Values ('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + DateTime.Now.ToLongDateString() + "',0,'" + comboBox2.Text + "')", Anasayfa.baglanti);
            komut2.ExecuteNonQuery();
            Anasayfa.baglanti.Close();
            Anasayfa.baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("update parkyeri set durum='1' where parkyeri LIKE'" + comboBox1.Text + "'", Anasayfa.baglanti);
            komut3.ExecuteNonQuery();
            Anasayfa.baglanti.Close();
            Anasayfa.baglanti.Open();
            OleDbCommand komut4 = new OleDbCommand("Insert Into gecmis (plaka,adi,soyadi,marka,model,p,aracyikama,gsaat) Values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + DateTime.Now.ToLongDateString() + "')", Anasayfa.baglanti);
            komut4.ExecuteNonQuery();
            Anasayfa.baglanti.Close();
            MessageBox.Show("Kayıt tamamlanmıştır.", "Başarıyla tamamlandı");
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Kayit_Load(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
