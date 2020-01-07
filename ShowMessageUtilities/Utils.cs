using System;
using System.IO;

namespace ShowMessageUtilities
{
    public static class Utils
    {
        public static string GetPluginResourceDir()
        {           
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, "Autodesk", "Revit", "Addins", "2020", "ShowMessagePlugin", "Resources");
        }
    }
}
