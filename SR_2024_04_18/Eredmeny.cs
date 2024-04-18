using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_2024_04_18
{
    class Eredmeny
    {
        public int Id { get; set; }
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public string Targy { get; set; }
        public int Szazalek { get; set; }
        public int Erdemjegy
        {
            get
            {
                if (Szazalek < 20)
                {
                    return 1;
                }
                else if (Szazalek >= 20 && Szazalek < 40)
                {
                    return 2;
                }
                else if (Szazalek >= 40 && Szazalek < 60)
                {
                    return 3;
                }
                else if (Szazalek >= 60 && Szazalek < 80)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
        public override string ToString()
        {
            return $"Eredmény<{Vezeteknev} {Keresztnev}: {Erdemjegy}>";
        }

        public static Eredmeny CreateFromLine(string line, char separator = ',')
        {
            string[] values = line.Split(separator);

            return new Eredmeny()
            {
                Id = int.Parse(values[0]),
                Vezeteknev = values[1],
                Keresztnev = values[2],
                Targy = values[3],
                Szazalek = int.Parse(values[4])
            };
        }

    }
}
