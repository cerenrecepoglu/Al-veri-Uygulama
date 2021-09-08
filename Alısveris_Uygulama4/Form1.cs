using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alısveris_Uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            textBox11.Text = label2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox12.Text=="")
            {
                groupBox2.Visible = false;
            }
            else
            {
                int para;
                int para2;
                para2 = Convert.ToInt32(label2.Text);
                para = Convert.ToInt32(textBox12.Text);
                label2.Text = (para + para2).ToString();
                textBox12.Text = "";
                groupBox2.Visible = false;
            }
        }
        int sayac = 1;
        int fiyat = 2;
        private void button1_Click(object sender, EventArgs e)
        {            
            int arama;
            arama=listBox1.Items.IndexOf("DOMATES");
            if(arama==-1)
            {
                listBox1.Items.Add("DOMATES");
                listBox2.Items.Add(sayac);
                listBox3.Items.Add(fiyat);
            }
            else
            {                
                listBox2.Items.Remove(sayac);
                listBox3.Items.Remove(fiyat);
                sayac = sayac + 1;
                listBox2.Items.Add(sayac);
                fiyat = fiyat + 2;
                listBox3.Items.Add(fiyat);
            }
            toplam_tutar();
        }
        int sayac1 = 1;
        int fiyat1 = 3;
        private void button2_Click(object sender, EventArgs e)
        {
            int arama;
            arama = listBox1.Items.IndexOf("PATATES");
            if (arama == -1)
            {
                listBox1.Items.Add("PATATES");
                listBox2.Items.Add(sayac1);
                listBox3.Items.Add(fiyat1);
            }
            else
            {
                listBox2.Items.Remove(sayac1);
                listBox3.Items.Remove(fiyat1);
                sayac1 = sayac1 + 1;
                listBox2.Items.Add(sayac1);
                fiyat1 = fiyat1 + 3;
                listBox3.Items.Add(fiyat1);
            }
            toplam_tutar();
        }
        int sayac2 = 1;
        int fiyat2 = 3;
        private void button3_Click(object sender, EventArgs e)
        {
            int arama;
            arama = listBox1.Items.IndexOf("SOĞAN");
            if (arama == -1)
            {
                listBox1.Items.Add("SOĞAN");
                listBox2.Items.Add(sayac2);
                listBox3.Items.Add(fiyat2);
            }
            else
            {
                listBox2.Items.Remove(sayac2);
                listBox3.Items.Remove(fiyat2);
                sayac2 = sayac2 + 1;
                listBox2.Items.Add(sayac2);
                fiyat2 = fiyat2 + 3;
                listBox3.Items.Add(fiyat2);
            }
            toplam_tutar();
        }
        int sayac3 = 1;
        int fiyat3 = 4;
        private void button4_Click(object sender, EventArgs e)
        {
            int arama;
            arama = listBox1.Items.IndexOf("PATLICAN");
            if (arama == -1)
            {
                listBox1.Items.Add("PATLICAN");
                listBox2.Items.Add(sayac3);
                listBox3.Items.Add(fiyat3);
            }
            else
            {
                listBox2.Items.Remove(sayac3);
                listBox3.Items.Remove(fiyat3);
                sayac3 = sayac3 + 1;
                listBox2.Items.Add(sayac3);
                fiyat3 = fiyat3 + 4;
                listBox3.Items.Add(fiyat3);
            }
            toplam_tutar();
        }
        int sayac4 = 1;
        int fiyat4 = 3;
        private void button5_Click(object sender, EventArgs e)
        {
            int arama;
            arama = listBox1.Items.IndexOf("BİBER");
            if (arama == -1)
            {
                listBox1.Items.Add("BİBER");
                listBox2.Items.Add(sayac4);
                listBox3.Items.Add(fiyat4);
            }
            else
            {
                listBox2.Items.Remove(sayac4);
                listBox3.Items.Remove(fiyat4);
                sayac4 = sayac4 + 1;
                listBox2.Items.Add(sayac4);
                fiyat4 = fiyat4 + 3;
                listBox3.Items.Add(fiyat4);
            }
            toplam_tutar();
        }
        public void toplam_tutar()
        {
            int topla = 0;
            for(int i=0;i<listBox3.Items.Count;i++)
            {
                topla += Convert.ToInt32(listBox3.Items[i]);
            }
            textBox13.Text = topla.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox13.Text = "";
            sayac = 1;
            sayac1 = 1;
            sayac2 = 1;
            sayac3 = 1;
            sayac4 = 1;
            fiyat = 2;
            fiyat1 = 3;
            fiyat2 = 3;
            fiyat3 = 4;
            fiyat4 = 3;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox13.Text=="")
            {
                MessageBox.Show("Sepetinize ürün eklemelisiniz");
            }
            else
            {
                int bakiye;
                int tutar;
                int yenibakiye;
                bakiye = Convert.ToInt32(label2.Text);
                tutar = Convert.ToInt32(textBox13.Text);

                if (bakiye < tutar)
                {
                    MessageBox.Show("Bakiyeniz yetersiz. Lütfen para yükleyin");
                }
                else
                {
                    yenibakiye = bakiye - tutar;
                    label2.Text = yenibakiye.ToString();
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    textBox13.Text = "";
                    sayac = 1;
                    sayac1 = 1;
                    sayac2 = 1;
                    sayac3 = 1;
                    sayac4 = 1;
                    fiyat = 2;
                    fiyat1 = 3;
                    fiyat2 = 3;
                    fiyat3 = 4;
                    fiyat4 = 3;
                    MessageBox.Show("Alışverişiniz tamamlanmıştır. İyi günler");
                }
            }
        }
    }
}
