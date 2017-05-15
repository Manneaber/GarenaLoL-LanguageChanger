using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLLCULanguageChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            args[1] = "--locale=en_US";

            Process p = new Process();
            p.StartInfo.FileName = "lol.exe";
            p.StartInfo.Arguments = string.Join(" ", args.Skip(1));
            p.Start();

            Process.GetCurrentProcess().Kill();
        }
    }
}
