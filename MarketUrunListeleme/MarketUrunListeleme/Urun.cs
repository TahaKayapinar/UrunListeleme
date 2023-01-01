using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUrunListeleme
{
    internal class Urun
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _UrunAdi;
        public string UrunAdi
        {
            get { return _UrunAdi; }
            set { _UrunAdi = value; }
        }

        private string _BarkodNo;
        public string BarkodNo
        {
            get { return _BarkodNo; }
            set { _BarkodNo = value; }
        }

        private string _BirimFiyat;
        public string BirimFiyat
        {
            get { return _BirimFiyat; }
            set { _BirimFiyat = value; }
        }

        private string _UrunSinifi;
        public string UrunSinifi
        {
            get { return _UrunSinifi; }
            set { _UrunSinifi = value; }
        }
        private DateTime _SKT;
        public DateTime SKT
        {
            get { return _SKT; }
            set { _SKT = value; }
        }

        public DateTime BirthDate { get; internal set; }



        public override string ToString()
        {
            return $"{this.Id} - {this.UrunAdi} = {this.BirimFiyat} TL";
        }
    }
}
