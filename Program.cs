using System;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;   // Нужна, чтобы запускать внешние процессы
using System.Threading;     // Нужна, чтобы скоротать время

namespace MakeAGETRequest_charp
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient(); // Она нужна непосредственно для работы с Web
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите широту города:");
            string lat = Console.ReadLine();
            Console.WriteLine("Введите долготу города:");
            string lon = Console.ReadLine();
            /*string coord = "https://time-in.ru/coordinates";
            string html1 = wc.DownloadString(coord);
            Console.WriteLine(html1);
            int indexlat = 0;
            if (city != null)
            {
                string s0 = city;
                int cityLenght = city.Length;
                indexlat = html1.IndexOf(s0+cityLenght+40);
            }
            else
            {
                Console.WriteLine("Введите название города");
            }
            int lat = 
            int lon = 139;
            */
            string Path = "https://api.openweathermap.org/data/2.5/weather?lat=" + lat + "&lon=" + lon + "&appid=49e50362b600b083ed675797ddb08fe4";
            string html = wc.DownloadString(Path);
            string a = Convert.ToString(thisDay);
            int[] b = new int[a.Length];
            for (int i = 0, j = 0; i < a.Length; i++)
            {
                if ((a[i] != '.') && (a[i] != ':') && (a[i] != ' '))
                {
                    b[j] = a[i] - '0';
                    j++;
                }
            }
  
            string writePath = @"C:\Users\Диана\Desktop\Собеседование2022\Лаверна\" + b[0]+ b[1] + " "+ b[2] + b[3] + " " + b[4]+ b[5] + b[6] + b[7] + ".txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                

                string s1 = "temp";
                int indextemp = html.IndexOf(s1);
                string[] te = new string[5];
                for (int i =0;i<16;i++)
                {
                    te[i] = html8;
                }
               
                Console.WriteLine("The temperature is: " + html[indextemp + 6] + html[indextemp + 7] + html[indextemp + 8] + html[indextemp + 9] + html[indextemp + 10] + html[indextemp + 11] + "\n");
                sw.WriteLine("The temperature is: " + html[indextemp + 6] + html[indextemp + 7] + html[indextemp + 8] + html[indextemp + 9] + html[indextemp + 10] + html[indextemp + 11] + "\n");
                string s2 = "humidity";
                int indexhumidity = html.IndexOf(s2);
                Console.WriteLine("The humidity is: " + html[indexhumidity + 10] + html[indexhumidity + 11] + "% \n");
                sw.WriteLine("The humidity is: " + html[indexhumidity + 10] + html[indexhumidity + 11] + "% \n");
                string s3 = "sunrise";
                int indexsunrise = html.IndexOf(s3);
                Console.WriteLine("The sunrise is in: " + html[indexsunrise + 8] + html[indexsunrise + 9] + html[indexsunrise + 10] + html[indexsunrise + 11] + html[indexsunrise + 12] + html[indexsunrise + 13] + html[indexsunrise + 14] + html[indexsunrise + 15] + html[indexsunrise + 16] + html[indexsunrise + 17] + "\n");
                sw.WriteLine("The sunrise is in: " + html[indexsunrise + 8] + html[indexsunrise + 9] + html[indexsunrise + 10] + html[indexsunrise + 11] + html[indexsunrise + 12] + html[indexsunrise + 13] + html[indexsunrise + 14] + html[indexsunrise + 15] + html[indexsunrise + 16] + html[indexsunrise + 17] + "\n");
                string s4 = "sunset";
                int indexsunset = html.IndexOf(s4);
                Console.WriteLine("The sunset is in: " + html[indexsunset + 8] + html[indexsunset + 9] + html[indexsunset + 10] + html[indexsunset + 11] + html[indexsunset + 12] + html[indexsunset + 13] + html[indexsunset + 14] + html[indexsunset + 15] + html[indexsunset + 16] + html[indexsunset + 17] + "\n");
                sw.WriteLine("The sunset is in: " + html[indexsunset + 8] + html[indexsunset + 9] + html[indexsunset + 10] + html[indexsunset + 11] + html[indexsunset + 12] + html[indexsunset + 13] + html[indexsunset + 14] + html[indexsunset + 15] + html[indexsunset + 16] + html[indexsunset + 17] + "\n");
            }
            return;
        }
    }
}
