using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Database
{
    public class Servers
    {
        public static string Paulo = @"Server=DESKTOPMARTINS\SQLEXPRESS;Database=Integradora;Trusted_Connection=true";
        public static string Ramires = @"";
        public static string Samuel = @"Server=SAMU-PC\SQLEXPRESS;Database=Integradora;UID=sa;PWD=19764582";
        private static string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
        public static string path = Path.GetDirectoryName(exeFile).Replace("\\bin\\Debug", "");
        public static string PathImages = "\\Images\\";
    }
}
