   M S B A M L   `   `   `  ����P  LGordanelliMaratonaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GordanelliMaratonaAppGordanelliMaratonaApp  5   	   &     GordanelliMaratonaApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:GordanelliMaratonaApp     5   	     � Title$  Maratona         ��5   	   $	��650��5	      $	��800��6   .��5
      �� .+�5   
   �� -   5         ��Name$ BtnLeggiDaFile��5      $��Leggi da file��6)   6A   �� 5   
   -   5        $ BtnAggiornaFile��5      $��Aggiorna il file��6*   6e   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgElencoAtleti��5      $	��209��6+   �� 5   
   $0��*Inserisci il nome dell'atleta e la città:��6   $
��Bold"�6D   �� 5   
   $��11(�6   .��6   Atleta6&   �� 5   
   -   5         ��Name$ TxTNome��5      �� 5   
   $��11(�6   .��6   Città6%   �� 5   
   -   5        $ TxTCitta��5      $��0q�6$   $��1q�60   �� 5   
   -   5        $ BtnCercaArtista��5      $��Visualizza Tempo��6*   6E   �� 5   
   $%��Inserisci il nome della città:��6   $
��Bold"�69   �� 5   
   -   5        $ TxTPartecipantiCitta��5      �� 5   
   -   5        $ BtnPartecipantiCittà��5      $��Partecipanti da città��6/   6O   �� 5   
   $>��8Stampa su file gli atleti migliori di quello selezionato��6   $
��Bold"�6S   �� 5   
   $��11(�6   .��6   Atleta6&   �� 5   
   -	   5        $ TxTAtletaEsempio��5      �� 5   
   $��11(�6   .��6   Città6%   �� 5   
   -
   5        $ TxTCittaEsempio��5      $��0q�6+   $��1q�67   �� 5   
   -   5        $ BtnStampaFile��5      $��Calcola atleti migliori��6(   6J   5      5      