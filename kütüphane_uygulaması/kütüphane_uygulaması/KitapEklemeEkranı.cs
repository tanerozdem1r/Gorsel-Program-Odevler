﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_uygulaması
{
    
    public partial class KitapEklemeEkranı : Form
    {
        AnaEkran AnaEkran;
        public KitapEklemeEkranı(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            AnaEkran = parametredenGelenAnaEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran.kitapEkle(textBox2.Text);
            AnaEkran.Show();
            this.Close();
        }

        private void KitapEklemeEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaEkran.Show();
        }
    }
}
