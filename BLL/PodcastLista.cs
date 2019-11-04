using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podden.BLL
{
    public class PodcastLista
    {
        private static List<Podcast> podcastLista { get; set; }

        public PodcastLista()
        {
            podcastLista = new List<Podcast>();
        }

        public static void laggTill(Podcast pod)
        {
            podcastLista.Add(pod);
        }

        public static List<Podcast> hamtaLista()
        {
            return podcastLista;
        }

        public static void TabortPodcast(string pTitel)
        {
            podcastLista.RemoveAll(pod => pod.PodcastTitel.Equals(pTitel));
        }
    }
}
