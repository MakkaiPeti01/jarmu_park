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
        public double UZEMANYAG 
        {
            get { return uzemAnyag; }
        }
        public double FOGYASZT
        {
            get { return fogyaszt; }
        }
        public double KM
        {
            get { return km; }
        }
        public double MEGTEHETO_KM
        {
            get { return megteheto_km; }
        }
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
            Console.WriteLine($"Km óra: {KM} km");
            Console.WriteLine($"Üzemanyag: {UZEMANYAG} L");
            Console.WriteLine($"Megtehető: {MEGTEHETO_KM} km");
            Console.WriteLine("----------------------------------");
        }
    }
}
