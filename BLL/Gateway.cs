using Podden.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podden.BLL
{
    public class Gateway
    {
        public static void LaggTillNyPodcast(string url, int freq, string kategori)
        {
            if (Validera.KollaRSS(url))
            {
                HanteraRssFeed.hamtaRssInfo(url, freq, kategori);
            }
        }

        public static void SkapaListor()
        {
            DAL.HanteraXML.SkapaListaPodcast();
            DAL.HanteraXML.SkapaListaAvsnitt();
            DAL.HanteraXML.SkapaListaKategori();
        }

        public static void SparaListor()
        {
            HanteraXML.SparaListaKategori();
            HanteraXML.SparaListaAvsnitt();
            HanteraXML.SparaListaPodcast();
        }
    }
}
