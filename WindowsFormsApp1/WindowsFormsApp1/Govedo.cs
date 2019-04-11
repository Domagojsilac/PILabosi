using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Govedo
    {

        private string naziv { get; set; }
        private string spol { get; set; }
        private string boja { get; set; }

        public Govedo()
        {


        }

        public Govedo(string naziv, string spol, string boja)
        {

            this.naziv = naziv;
            this.spol = spol;
            this.boja = boja;

        }

        public string IspisGovedo(List<Govedo> lista, string uvjetBoja, string uvjetSpol)
        {
            string uvjetBojaF = uvjetBoja;
            string uvjetSpolF = uvjetSpol;
            string ispis = "";
            foreach (Govedo vrat in lista)
            {
                if(uvjetBojaF == "" && uvjetSpolF == "")
                {
                    ispis += vrat.naziv + ", " + vrat.spol + ", " + vrat.boja + Environment.NewLine;
                }
                else if (uvjetBojaF == vrat.boja && uvjetSpolF == "")
                {
                    ispis += vrat.naziv + ", " + vrat.spol + ", " + vrat.boja + Environment.NewLine;
                }
                else if (uvjetBojaF == "" && uvjetSpolF == vrat.spol)
                {
                    ispis += vrat.naziv + ", " + vrat.spol + ", " + vrat.boja + Environment.NewLine;
                }
                else if (uvjetBojaF == vrat.boja && uvjetSpolF == vrat.spol)
                {
                    ispis += vrat.naziv + ", " + vrat.spol + ", " + vrat.boja + Environment.NewLine;
                }

            }
            return ispis;
        }

    }
}
