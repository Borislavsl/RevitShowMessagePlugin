using System.Reflection;
using Autodesk.Revit.UI;
using static ShowMessageUtilities.Utils;
using ShowMessageUtilities;

namespace ShowMessagePlugin
{
    public class ShowMessageCreatePlugin : IExternalApplication
    {      
        public Result OnStartup(UIControlledApplication application)
        {            
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("ShowMessage");

            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string smallBitmapFileName = "revit.png";

            var buttons = new PluginCommandButton[] { new PluginCommandButton("button1Name", "Message Box", assemblyPath, "ShowMessagePlugin.Commands.ShowMessageBox", smallBitmapFileName, "messagebox.png", "Opens a Windows form", true, true),
                                                      new PluginCommandButton("button2Name", "Model Text",  assemblyPath, "ShowMessagePlugin.Commands.ShowModelText",  smallBitmapFileName, "modelspace.jpg",  "Add text to model space")
                                                    };

            RevitAPI.AddSplitButtonGroup(ribbonPanel, "SplitGroup1", "Show Message", buttons);          

            return Result.Succeeded;
        }      

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
