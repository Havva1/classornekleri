using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classornekleri
{
    public class Personel:Maas,ICrudEylemleri
    {
        public string isim;
        public int numara;
        public string yer;
        public string gorev;
        private int bordro;

        public int Maas
        {

            get { return bordro; }


            set
            {

                if (value < 5000)
                {
                    MessageBox.Show("5000 Altında değer verilemez");
                }
                else
                {
                    bordro = value;
                }
            }
        }

        public string bilgiyaz()
        {
            string cumle = "Kişinin Adı" + this.isim + "Görevi" + gorev;
            return cumle;
        }

        public void Bul()
        {
            throw new NotImplementedException();
        }

        public void Ekle()
        {
            throw new NotImplementedException();
        }

        public void Guncelle()
        {
            throw new NotImplementedException();
        }

        public void Silme()
        {
            throw new NotImplementedException();
        }

        public override void vergi()
        {
            int hesap = (Maas * 20) / 100;
            MessageBox.Show("Vergi" + hesap); 
        }

        public override void yuzde()
        {
            throw new NotImplementedException();
        }
    }
}
