﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podden.BLL
{
    public class AvsnittsInfo
    {
        private string podcastTitel;
        private string avsnittTitel;
        private string beskrivning;

        public AvsnittsInfo(string podcastTitel, string avsnittTitel, string beskrivning)
        {
            this.podcastTitel = podcastTitel;
            this.avsnittTitel = avsnittTitel;
            this.beskrivning = beskrivning;
        }

        public AvsnittsInfo()
        {

        }

        public virtual string hamtaInfo()
        {
            string nl = "\r\n";
            return avsnittTitel + nl + beskrivning + "Override this plz";
        }
    }
}
