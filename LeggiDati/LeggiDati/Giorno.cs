using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeggiDati
{
    public class Giorno
    {
        public string Data { get; set; }
        public string RicoveratiConSintomi { get; set; }
        public string TerapiaIntensiva { get; set; }
        public string TotaleOspedalizzati { get; set; }
        public string IsolamentoDomiciliare { get; set; }
        public string TotalePositivi { get; set; }
        public string VariazioneTotalePositivi { get; set; }
        public string NuoviPositivi { get; set; }
        public string DimessiGuariti { get; set; }
        public string Deceduti { get; set; }
        public string TotaleCasi { get; set; }
        public string Tamponi { get; set; }

        public Giorno( string data, string RicSin, string TerInt, string TotOsp, string IsoDoc, string TotPos, string VarTotPos, string NuoPos, string DimGua, string Dec,string TotCas, string Tam )
        {
            Data = data.Substring(0,10);
            RicoveratiConSintomi = RicSin;
            TerapiaIntensiva = TerInt;
            TotaleOspedalizzati = TotOsp;
            IsolamentoDomiciliare = IsoDoc;
            TotalePositivi = TotPos;
            VariazioneTotalePositivi = VarTotPos;
            NuoviPositivi = NuoPos;
            DimessiGuariti = DimGua;
            Deceduti = Dec;
            TotaleCasi = TotCas;
            Tamponi = Tam;

        }

        public override string ToString()
        {
            return this.Data;
        }
    }
}
