using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classornekleri
{
    public interface ICrudEylemleri
    {
        void Ekle();
        void Silme();
        void Guncelle();
        void Bul();
    }
}
