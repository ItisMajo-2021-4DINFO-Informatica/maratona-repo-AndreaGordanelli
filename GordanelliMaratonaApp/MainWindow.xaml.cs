using System.Windows;

namespace GordanelliMaratonaApp {

    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ListaMaratoneti Lista;
        public MainWindow() {
            InitializeComponent();
            Lista = new ListaMaratoneti();
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e) {
            Lista.LeggiDati();
            DgElencoAtleti.ItemsSource = Lista.elencoMaratoneti;
            DgElencoAtleti.Items.Refresh();
            BtnLeggiDaFile.IsEnabled = false;
        }

        private void BtnVisualizzaTempo_Click(object sender, RoutedEventArgs e) {
            foreach(Maratoneta maratoneta in Lista.elencoMaratoneti) {
                if(maratoneta.nomeAtleta == TxTNome.Text && maratoneta.cittàCorsa == TxTCitta.Text) {
                    MessageBox.Show($"L'atleta: {maratoneta.nomeAtleta} durante la gara svolta a {maratoneta.cittàCorsa} ha corso per {maratoneta.TempoSec()}");
                }
            }
        }
    }
}