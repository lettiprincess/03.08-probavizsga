using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonferenciaProject
{
    class Konferencia
    {
        private List<Eloadas> eloadasok;

        public Konferencia(List<Eloadas> eloadasok)
        {
            this.Eloadasok = eloadasok;

            try {
                StreamReader sr = new StreamReader("konferencia.txt");
                string s = sr.ReadLine();
                string[] szetszedes = s.Split(';');

                for (int i = 0; i < eloadasok.Count; i++)
                {

                }
            }
            catch (Exception e) {
                Console.WriteLine("Hiba: " + e);
            }
        }

        internal List<Eloadas> Eloadasok
        {
            get
            {
                return eloadasok;
            }

            set
            {
                eloadasok = value;
            }
        }

    }
}
