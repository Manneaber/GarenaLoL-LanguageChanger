using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoLLCULanguageChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", args));
            Console.Write("Choose your language (blank or 0: TH, 1: EN) : ");
            string getstr = Console.ReadLine();
            if (getstr == "1")
            {
                args[1] = "--locale=en_US";
            }

            Process p = new Process();
            p.StartInfo.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\LeagueClient\LeagueClient.exe";
            p.StartInfo.Arguments = string.Join(" ", args.Skip(1));
            p.Start();

            Process.GetCurrentProcess().Kill();
        }
    }
}
