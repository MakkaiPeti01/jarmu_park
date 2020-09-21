using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu_park
{
    class Auto
    {
        string szin, tipus;
        double uzemAnyag, fogyaszt, km, megteheto_km;
        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.km = 0;
            this.megteheto_km = 0;
            this.uzemAnyag = 0;

        }
        private void Megteheto()
        {
            megteheto_km = uzemAnyag / fogyaszt * 100;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            Megteheto();
        }
        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            Megteheto();
        }
        public void Allapot()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} L");
            Console.WriteLine($"Megtehető: {megteheto_km} km");
            Console.WriteLine("----------------------------------");
        }
    }
}
