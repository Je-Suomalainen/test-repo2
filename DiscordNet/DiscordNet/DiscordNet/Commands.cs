using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using Discord.WebSocket;


namespace DiscordNet
{
    public class Commands : ModuleBase
    {
        [Command("ruoka")]
        public async Task Ruoka()
        {
            string path = @"C:\dev\Ohjelmoinnin perusteet\test-repo2\DiscordNet\DiscordNet\DiscordNet\TextFile\ruokalista.txt";
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("http://www.kampusravintolat.fi/fi/lutbuffet");
            string tulos = StripHTML(webData);
            int value = tulos.LastIndexOf("__***MAANANTAI***__");
            string tulos1 = tulos.Substring(value);
            int value1 = tulos1.IndexOf("Kela tukee");
            string tulos2 = tulos1.Substring(0, value1);
            _ = await ReplyAsync(tulos2);        //remove this if you use code commented under

            //using (StreamWriter sw = new StreamWriter(path))          //use this if you want readable  .txt file adn message from there 
            //{
            //    sw.WriteLine("VIIKON RUOKALISTA \n \n" + tulos2);
            //}
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadToEnd()) != null)
            //    {
            //        var msg = await ReplyAsync(s);
            //    }
            //} 







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
                input = Regex.Replace(input, "Maanantai", "\t__***MAANANTAI***__");
                input = Regex.Replace(input, "Tiistai", "\t__***TIISTAI***__");
                input = Regex.Replace(input, "Keskiviikko", "\t__***KESKIVIIKKO***__");
                input = Regex.Replace(input, "Torstai", "\t__***TORSTAI***__");
                input = Regex.Replace(input, "Perjantai", "\t__***PERJANTAI***__");
                input = Regex.Replace(input, "Lauantai", "\t__***LAUANTAI***__");
                input = Regex.Replace(input, "Sunnuntai", "\t__***SUNNUNTAI***__");
                input = Regex.Replace(input, "Ã¶", "ö");
                input = Regex.Replace(input, "Ã¤", "ä");
                input = Regex.Replace(input, "Â", string.Empty);
                input = Regex.Replace(input, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                





            }

            return input;
        }
        [Command("ping")]
        
        public async Task Ping()
        {
            var msg = await ReplyAsync("***Lasketaan...***");
            await ReplyAsync($"Pong! ***{msg.Timestamp.Millisecond - DateTime.Now.Millisecond}***ms");
            await msg.DeleteAsync();

        }
        [Command("kick")]
        [RequireUserPermission(Discord.GuildPermission.Administrator)]
        public async Task Kick(SocketGuildUser mention, string reason = null)
        {
            if (mention != null)
            {
                await mention.KickAsync();

                await ReplyAsync(reason == null ? $"{mention.Username} on poistettu palvelimelta ilman erityistä syytä " : $"{mention.Username} on poistettu palvelimelta. Syy: {reason}");
            }
        }
        [Command("sää")]
        public async Task Sää()
        {
            string path2 = @"C:\dev\Ohjelmoinnin perusteet\test-repo2\DiscordNet\DiscordNet\DiscordNet\TextFile\sää.txt";
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("https://ilmatieteenlaitos.fi/2");
            string tulos = Strip(webData);
            int value = tulos.LastIndexOf("__***SÄÄTIEDOTUS***__");
            string tulos1 = tulos.Substring(value);
            int value1 = tulos1.IndexOf("Säätiedotus merenkulkijoille");
            string tulos2 = tulos1.Substring(0, value1);
            _ = await ReplyAsync(tulos2);

            //using (StreamWriter sw = new StreamWriter(path2))         
            //{
            //    sw.WriteLine(tulos2);
            //}
            //using (StreamReader sr = File.OpenText(path2))
            {
                //string s;
                //while ((s = sr.ReadToEnd()) != null)
                //{
                //    var msg = await ReplyAsync(s);
                //}
            }
        }
        static string Strip(string syöte)
        {

            if (!string.IsNullOrEmpty(syöte))
            {

                syöte = Regex.Replace(syöte, "Ã¶", "ö");
                syöte = Regex.Replace(syöte, "Ã¤", "ä");
                syöte = Regex.Replace(syöte, "1527144975000", string.Empty);
                syöte = Regex.Replace(syöte, "Â", string.Empty);
                syöte = Regex.Replace(syöte, "<.*?>", String.Empty);
                syöte = Regex.Replace(syöte, "{.*?}", String.Empty);
                syöte = Regex.Replace(syöte, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline); 
                syöte = Regex.Replace(syöte, "Sää ja meri", "__***SÄÄTIEDOTUS***__");


            }

            return syöte;
        }




        [Command("mää")]
        public async Task Mää()
            

        {
            var msg = await ReplyAsync("***OON TÄÄ KISSA***");

            await ReplyAsync("https://gph.is/1URYQQ1");
        }
        
        [Command ("help")]
        public async Task Help()
        {
            var msg = await ReplyAsync("***!ruoka*** - Kertoo viikon ruokalistan LUT-Buffetissa \n ***!sää*** - Kertoo uusimman sääennusteen koko maahan \n ***!mää*** - Oon tää... \n ***!ping*** - kertoo viiveen botin ja serverin välillä \n ***!kalenteri*** - kertoo viikon lukujärjestyksen");
        }


        [Command("kalenteri")]
        public async Task Kalenteri()
        {
            string path3 = @"C:\dev\Ohjelmoinnin perusteet\test-repo2\DiscordNet\DiscordNet\DiscordNet\TextFile\kalenteri.txt";
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("https://cloud.timeedit.net/lut-saimia/web/public/ri1Y5XYQQ7wZ06QfZ5071345y1YQ7.html");
            string tulos = Strip3(webData);
            int value = tulos.LastIndexOf("__***VIIKON LUKUJÄRJESTYS***__");
            string tulos1 = tulos.Substring(value);
            int value1 = tulos1.IndexOf("Lauantai");
            string tulos2 = tulos1.Substring(0, value1);
            _ = await ReplyAsync(tulos2);        //remove this if you use code commented under

            //using (StreamWriter sw = new StreamWriter(path3))          
            //{
            //    sw.WriteLine(tulos2);
            //}
            //using (StreamReader sr = File.OpenText(path3))
            //{
            //    string s;
            //    while ((s = sr.ReadToEnd()) != null)
            //    {
            //        var msg = await ReplyAsync(s);
            //    }
            //}







        }

        static string Strip3(string syöte2)
        {

            if (!string.IsNullOrEmpty(syöte2))
            {
                syöte2 = Regex.Replace(syöte2, "<.*?>", String.Empty);
                syöte2 = Regex.Replace(syöte2, "{.*?}", String.Empty);
                syöte2 = Regex.Replace(syöte2, "Ã¶", "ö");
                syöte2 = Regex.Replace(syöte2, "&nbsp;", string.Empty);
                syöte2 = Regex.Replace(syöte2, "891011121314151617181920", string.Empty);
                syöte2 = Regex.Replace(syöte2, "Ã¤", "ä");
                syöte2 = Regex.Replace(syöte2, "Â", string.Empty);
                syöte2 = Regex.Replace(syöte2, ".Lectures", string.Empty);
                syöte2 = Regex.Replace(syöte2, "10:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "11:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "12:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "13:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "14:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "15:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "16:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "17:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "08:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "09:00", string.Empty);
                syöte2 = Regex.Replace(syöte2, "19001", string.Empty);
                syöte2 = Regex.Replace(syöte2, "19002", string.Empty);
                syöte2 = Regex.Replace(syöte2, "19003", string.Empty);
                syöte2 = Regex.Replace(syöte2, "19006", string.Empty);
                syöte2 = Regex.Replace(syöte2, "1919002", string.Empty);
                syöte2 = Regex.Replace(syöte2, "v47", string.Empty);
                syöte2 = Regex.Replace(syöte2, "11:1510:15", "10:15");
                syöte2 = Regex.Replace(syöte2, "Maanantai", "__***MAANANTAI***__    ");
                syöte2 = Regex.Replace(syöte2, "HOTRA19H", "    ");
                syöte2 = Regex.Replace(syöte2, "LITAD19", "    ");
                syöte2 = Regex.Replace(syöte2, "HOTRA19R", "    ");
                syöte2 = Regex.Replace(syöte2, "LITAM19", "    ");
                syöte2 = Regex.Replace(syöte2, ",", string.Empty);
                syöte2 = Regex.Replace(syöte2, "Tiistai", "__***TIISTAI***__    ");
                syöte2 = Regex.Replace(syöte2, "Keskiviikko", "__***KESKIVIIKKO***__    ");
                syöte2 = Regex.Replace(syöte2, "Torstai", "__***TORSTAI***__    ");
                syöte2 = Regex.Replace(syöte2, "Perjantai", "__***PERJANTAI***__    ");
                syöte2 = Regex.Replace(syöte2, "osoitetta sen sijaan.", "__***VIIKON LUKUJÄRJESTYS***__");
                syöte2 = Regex.Replace(syöte2, ".Luennot", string.Empty);
                syöte2 = Regex.Replace(syöte2, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);






                
            }
            

            return syöte2;
        }

    }
}
