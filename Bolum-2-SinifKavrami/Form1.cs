using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum_2_SinifKavrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Örnek (Instance) alma.
            Bilgisayar laptop = new Bilgisayar();
            //laptop.marka = "Dell";
            //laptop.model = "Xps";
            //laptop.ekranBoyut = 15.6;
            //laptop.isletimSistemi = "Windows";
            //laptop.islemci = "i7";
            //laptop.ram = 16;
            //laptop.hdKapasite = 1000;
            //laptop.fiyat = 10000;

            //MessageBox.Show(laptop.marka);

            laptop.Marka = "Dell";
            laptop.Model = "Xps";

            MessageBox.Show(laptop.Marka);
        }
    }
}
