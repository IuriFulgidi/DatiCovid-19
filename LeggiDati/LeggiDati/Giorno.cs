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
        public int RicoveratiConSintomi { get; set; }
        public int TerapiaIntensiva { get; set; }
        public int TotaleOspedalizzati { get; set; }
        public int IsolamentoDomiciliare { get; set; }
        public int TotalePositivi { get; set; }
        public int VariazioneTotalePositivi { get; set; }
        public int NuoviPositivi { get; set; }
        public int DimessiGuariti { get; set; }
        public int Deceduti { get; set; }
        public int TotaleCasi { get; set; }
        public int Tamponi { get; set; }

        public Giorno( string data, string RicSin, string TerInt, string TotOsp, string IsoDoc, string TotPos, string VarTotPos, string NuoPos, string DimGua, string Dec,string TotCas, string Tam )
        {
            Data = data.Substring(0,10);
            RicoveratiConSintomi = Convert.ToInt32(RicSin);
            TerapiaIntensiva = Convert.ToInt32(TerInt);
            TotaleOspedalizzati = Convert.ToInt32(TotOsp);
            IsolamentoDomiciliare = Convert.ToInt32(IsoDoc);
            TotalePositivi = Convert.ToInt32(TotPos);
            VariazioneTotalePositivi = Convert.ToInt32(VarTotPos);
            NuoviPositivi = Convert.ToInt32(NuoPos);
            DimessiGuariti = Convert.ToInt32(DimGua);
            Deceduti = Convert.ToInt32(Dec);
            TotaleCasi = Convert.ToInt32(TotCas);
            Tamponi = Convert.ToInt32(Tam);

        }

        public override string ToString()
        {
            return this.Data;
        }
    }
}
