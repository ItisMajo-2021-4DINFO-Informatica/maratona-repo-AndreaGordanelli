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
            MessageBox.Show(Lista.VisualizzaTempo(TxTNome.Text, TxTCitta.Text));
        }

        private void BtnPartecipantiCittà_Click(object sender, RoutedEventArgs e) {

        }

        private void BtnStampaFile_Click(object sender, RoutedEventArgs e) {

        }
    }
}