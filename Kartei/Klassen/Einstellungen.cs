using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteien.Klassen
{
    static class Einstellungen
    {
        public static string Host = "THINKPADT440S";
        public static string DataBase = "";
        public static string SQLUser = "Test";
        public static string Passwort = "123";

        /// <summary>
        /// Lade Einstellungen aus Config File
        /// </summary>
        public static void LoadFromConfig()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                Host = appSettings["Server"] ?? "Not Found";
                DataBase = appSettings["DataBase"] ?? "Not Found";
                SQLUser = appSettings["User"] ?? "Not Found";
                Passwort = appSettings["Kennwort"] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
    }
}
