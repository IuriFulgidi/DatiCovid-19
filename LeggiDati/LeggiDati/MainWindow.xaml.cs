using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace LeggiDati
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Giorno> giorni = new List<Giorno>();
        public MainWindow()
        {
            InitializeComponent();

            CaricaCombo();
        }

        private void CaricaCombo()
        {
            //si cerca la lista di giorni
            string path = @"datiCorona.xml";
            XDocument xmlDoc = XDocument.Load(path);
            XElement xmlgiorni = xmlDoc.Element("giorni");
            var xmlListaGiorni = xmlgiorni.Elements("giorno");

            foreach (var xmlgiorno in xmlListaGiorni)
            {
                //ricavo informazioni da xml
                XElement xmlData = xmlgiorno.Element("data");
                XElement xmlRicSin = xmlgiorno.Element("ricoverati_con_sintomi");
                XElement xmlTerInt = xmlgiorno.Element("terapia_intensiva");
                XElement xmlTotOsp = xmlgiorno.Element("totale_ospedalizzati");
                XElement xmlIsoDoc = xmlgiorno.Element("isolamento_domiciliare");
                XElement xmlTotPos = xmlgiorno.Element("totale_positivi");
                XElement xmlVarTotPos = xmlgiorno.Element("variazione_totale_positivi");
                XElement xmlNuoPos = xmlgiorno.Element("nuovi_positivi");
                XElement xmlDimGua = xmlgiorno.Element("dimessi_guariti");
                XElement xmlDec = xmlgiorno.Element("deceduti");
                XElement xmlTotCas = xmlgiorno.Element("totale_casi");
                XElement xmlTam = xmlgiorno.Element("tamponi");

                //creazione giorno
                Giorno g = new Giorno(xmlData.Value, xmlRicSin.Value, xmlTerInt.Value, xmlTotOsp.Value, xmlIsoDoc.Value, xmlTotPos.Value, xmlVarTotPos.Value, xmlNuoPos.Value, xmlDimGua.Value, xmlDec.Value, xmlTotCas.Value, xmlTam.Value);
                giorni.Add(g);
            }

            cmb_data.ItemsSource = giorni;
        }

        private void Cmb_data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lst_dati.Items.Clear();

            Giorno g = (Giorno)cmb_data.SelectedItem;

            lst_dati.Items.Add($"Data: {g.Data}");
            lst_dati.Items.Add($"Ricoverati con sintomi: {g.RicoveratiConSintomi}");
            lst_dati.Items.Add($"In terapia intensiva: {g.TerapiaIntensiva}");
            lst_dati.Items.Add($"Totale degli ospedalizzati: {g.TotaleOspedalizzati}");
            lst_dati.Items.Add($"In Isolamenti dmicialiare: {g.IsolamentoDomiciliare}");
            lst_dati.Items.Add($"Totale dei positivi: {g.TotalePositivi}");
            lst_dati.Items.Add($"Varaizione del totale dei positivi: {g.VariazioneTotalePositivi}");
            lst_dati.Items.Add($"Nuovi positivi dal giorno precedente: {g.NuoviPositivi}");
            lst_dati.Items.Add($"Dimessi guariti: {g.DimessiGuariti}");
            lst_dati.Items.Add($"Deceduti: {g.Deceduti}");
            lst_dati.Items.Add($"Totale dei casi: {g.TotaleCasi}");
            lst_dati.Items.Add($"Totale dei tamponi fatti: {g.Tamponi}");
        }
    }
}
