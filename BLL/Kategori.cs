using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podden.BLL
{
    public class Kategori
    {
        private string kategoriTitel { get; set; }

        public Kategori(string kategori)
        {
            kategoriTitel = kategori;
        }

        public Kategori()
        {

        }

        public string KategoriTitel
        {
            get { return kategoriTitel; }
            set { kategoriTitel = value; }
        }
    }
}
