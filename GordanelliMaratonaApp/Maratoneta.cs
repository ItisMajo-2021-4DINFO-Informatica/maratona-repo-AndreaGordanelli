using System;

namespace GordanelliMaratonaApp {

    internal class Maratoneta {
        public string nomeAtleta { get; set; }
        public string società { get; set; }
        public string tempoImpiegato { get; set; }
        public string cittàCorsa { get; set; }

        public int TempoSec(Maratoneta maratoneta) {
            string ora = maratoneta.tempoImpiegato;
            ora = ora.Replace("m", "");
            ora = ora.Replace("h", "");
            int minuti = Int16.Parse(ora.Substring(ora.Length - 2, ora.Length - 1)) + Int16.Parse((ora.Substring(0, ora.Length - 2))) * 60;
            return (minuti);
        }
    }
}