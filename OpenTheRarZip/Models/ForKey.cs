using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTheRarZip.Models
{
    public class ForKey
    {
        string Donut;
        public string SadeceSayilar( int uzunluk)
        {
            Donut = "";
            Random rnd = new Random();
            string Degerler = "0123456789";
            for (int i = 0; i < uzunluk; i++)
            {
                Donut += Degerler[rnd.Next(Degerler.Length)];
            }
            return Donut;
        }
        public string SadeceKucukHarfler( int uzunluk)
        {
            Donut = "";
            Random rnd = new Random();
            string Degerler = "abcçdefgğhiıjklmnoöprsştuüvyz";
            for (int i = 0; i < uzunluk; i++)
            {
                Donut += Degerler[rnd.Next(Degerler.Length)];
            }
            return Donut;
        }
        public string SadeceBuyukHarfler( int uzunluk)
        {
            Donut = "";
            Random rnd = new Random();
            string Degerler = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ";
            for (int i = 0; i < uzunluk; i++)
            {
                Donut += Degerler[rnd.Next(Degerler.Length)];
            }
            return Donut;
        }    
        public string BuyukVeKucukHarfler( int uzunluk)
        {
            Donut = "";
            Random rnd = new Random();
            string Degerler = "AaBbCcÇçDdEeFfGgĞğHhİiIıJjKkLlMmNnOoÖöPpRrSsŞşTtUuÜüVvYyZz";
            for (int i = 0; i < uzunluk; i++)
            {
                Donut += Degerler[rnd.Next(Degerler.Length)];
            }
            return Donut;
        }
        public string BuyukVeKucukHarflerVeSayilar( int uzunluk)
        {
            Donut = "";
            Random rnd = new Random();
            string Degerler = "AaBbCcÇçDdEeFfGgĞğHhİiIıJjKkLlMmNnOoÖöPpRrSsŞşTtUuÜüVvYyZz0123456789";
            for (int i = 0; i < uzunluk; i++)
            {
                Donut += Degerler[rnd.Next(Degerler.Length)];
            }
            return Donut;
        }
        public string BuyukVeKucukHarflerVeSayilarVeSimgeler( int uzunluk)
        {
            Donut = "";
            Random rnd = new Random();
            string Degerler = "AaBbCcÇçDdEeFfGgĞğHhİiIıJjKkLlMmNnOoÖöPpRrSsŞşTtUuÜüVvYyZz0123456789é!'^+%&/()=?_-*<>£#$½{[]}\\|";
            for (int i = 0; i < uzunluk; i++)
            {
                Donut += Degerler[rnd.Next(Degerler.Length)];
            }
            return Donut;
        }
    }
}
