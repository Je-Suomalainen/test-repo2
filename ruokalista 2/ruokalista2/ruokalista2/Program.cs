using System;
using System.Net.Http;
using System.IO;
using System.Text.RegularExpressions;

namespace discordtestibotti
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\dev\Ohjelmoinnin perusteet\test-repo2\ruokalista 2\ruokalista2\ruokalista2\textfile\ruokalista.txt";
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("http://www.kampusravintolat.fi/fi/lutbuffet");
            string tulos = StripHTML(webData);
            int value = tulos.LastIndexOf("*MAANANTAI*");
            string tulos1 = tulos.Substring(value);
            int value1 = tulos1.IndexOf("Kela tukee");
            string tulos2 = tulos1.Substring(0, value1);


            




            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("VIIKON RUOKALISTA \n \n" +  tulos2);
            }


        }

        static string StripHTML(string input)
        {

            if (!string.IsNullOrEmpty(input))
            {
                input = Regex.Replace(input, "<.*?>", String.Empty);
                input = Regex.Replace(input, "{.*?}", String.Empty);
                input = Regex.Replace(input, "3,74", string.Empty);
                input = Regex.Replace(input, "4,60", string.Empty);
                input = Regex.Replace(input, "5,20", string.Empty);
                input = Regex.Replace(input, "4,14", string.Empty);
                input = Regex.Replace(input, "5,70", string.Empty);
                input = Regex.Replace(input, "7,50", string.Empty);
                input = Regex.Replace(input, "4,54", string.Empty);
                input = Regex.Replace(input, "5,70", string.Empty);
                input = Regex.Replace(input, "7,50", string.Empty);
                input = Regex.Replace(input, "4,14", string.Empty);
                input = Regex.Replace(input, "6,14", string.Empty);
                input = Regex.Replace(input, "7,30", string.Empty);
                input = Regex.Replace(input, "9,50", string.Empty);
                input = Regex.Replace(input, "6,89", string.Empty);
                input = Regex.Replace(input, "8,50", string.Empty);
                input = Regex.Replace(input, "11,00", string.Empty);
                input = Regex.Replace(input, "4,60", string.Empty);
                input = Regex.Replace(input, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                input = Regex.Replace(input, "Maanantai", "\n *MAANANTAI*");
                input = Regex.Replace(input, "Tiistai", "\n *TIISTAI*");
                input = Regex.Replace(input, "Keskiviikko", "\n *KESKIVIIKKO*");
                input = Regex.Replace(input, "Torstai", "\n *TORSTAI*");
                input = Regex.Replace(input, "Perjantai", "\n *PERJANTAI*");
                input = Regex.Replace(input, "Lauantai", "\n *LAUANTAI*");
                input = Regex.Replace(input, "Sunnuntai", "\n *SUNNUNTAI*");




            }

            return input;
        }
    }
}