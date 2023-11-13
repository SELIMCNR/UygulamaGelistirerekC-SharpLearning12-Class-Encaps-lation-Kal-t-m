using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class araba : ArabaDetay
    {
        //class özellikleri
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

        private int yil; //değişken alan
        private string Marka;
        //encapsülation
        public int Yıl
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string Markası
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
