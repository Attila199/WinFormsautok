using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsautok
{
    internal class Auto
    {
        int id;
        string rendszam;
        int evjarat;
        string szam;

        public int Id { get => id; set => id = value; }
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public string Szam { get => szam; set => szam = value; }

        public Auto(int id, string rendszam, int evjarat, string szam)
        {
            Id = id;
            Rendszam = rendszam;
            Evjarat = evjarat;
            Szam = szam;
        }
        public override string ToString()
        {
            return rendszam + "(" + evjarat + ")" + szam;
        }
    }
}
