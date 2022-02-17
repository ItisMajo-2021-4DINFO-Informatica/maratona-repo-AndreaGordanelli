using System.Collections.Generic;
using System.IO;

namespace GordanelliMaratonaApp {

    internal class ListaMaratoneti {
        public List<Maratoneta> elencoMaratoneti;

        public ListaMaratoneti() {
            elencoMaratoneti = new List<Maratoneta>();
        }

        public void Aggiungi(Maratoneta brano) {
            elencoMaratoneti.Add(brano);
        }

        public void LeggiDati() {
            using (FileStream flussoDati = new FileStream("input.txt", FileMode.Open, FileAccess.Read)) {
                using (StreamReader lettoreDati = new StreamReader(flussoDati)) {
                    while (!lettoreDati.EndOfStream) {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        Maratoneta maratoneta = new Maratoneta();
                        maratoneta.nomeAtleta = campi[0];
                        maratoneta.società = campi[1];
                        maratoneta.tempoImpiegato = campi[2];
                        maratoneta.cittàCorsa = campi[3];

                        Aggiungi(maratoneta);
                    }
                }
            }
        }

        public string VisualizzaTempo(string TxTNome, string TxTCitta) {
            string output = "";
            foreach (Maratoneta maratoneta in elencoMaratoneti) {
                if (maratoneta.nomeAtleta == TxTNome && maratoneta.cittàCorsa == TxTCitta) {
                    output = $"L'atleta: {maratoneta.nomeAtleta} durante la gara svolta a {maratoneta.cittàCorsa} ha corso per {maratoneta.TempoSec(maratoneta)} minuti";
                }
            }
            output = output.Length < 1 ? "Nessun atleta trovato" : output;
            return output;
        }

        public string PartecipantiCitta(string TxTCitta) {
            string output = "";
            foreach (Maratoneta maratoneta in elencoMaratoneti) {
                if (maratoneta.cittàCorsa == TxTCitta) {
                    output += $"{maratoneta.nomeAtleta}\n";
                }
            }
            return output = output.Length < 1 ? "Nessun risultato trovato" : output;
        }
    }
}