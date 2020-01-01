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

        public static ShowMessageButton[] GetShowMessageButtons()
        {
            string smallBitmapFileName = "revit.png";

            var buttons = new ShowMessageButton[] { new ShowMessageButton("button1Name", "Message Box", "ShowMessagePlugin.ShowMessageBox", smallBitmapFileName, "messagebox.png", "Opens a Windows form", true, true),                                                    
                                                    new ShowMessageButton("button2Name", "Model Text",  "ShowMessagePlugin.ShowModelText",  smallBitmapFileName, "modelspace.jpg",  "Add text to model space")
                                                  };
            return buttons;
        }

        public static string GetTestDocumentPath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, "Autodesk", "Revit", "Addins", "2020", "ShowMessagePlugin", "Resources", "ShowMessageFamily.rfa");
        }
    }
}
