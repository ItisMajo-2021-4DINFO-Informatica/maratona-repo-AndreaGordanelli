using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GordanelliMaratonaApp {
    class ListaMaratoneti {
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
    }
}

  
