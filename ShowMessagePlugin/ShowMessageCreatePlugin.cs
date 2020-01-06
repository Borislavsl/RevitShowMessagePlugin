using System;
using System.Reflection;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Events;
using static ShowMessageUtilities.Utils;
using ShowMessageUtilities;

namespace ShowMessagePlugin
{
    public class ShowMessageCreatePlugin : IExternalApplication
    {      
        public Result OnStartup(UIControlledApplication application)
        {            
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("ShowMessage");

            AddSplitButtonGroup(ribbonPanel);          

            return Result.Succeeded;
        }

        private void AddSplitButtonGroup(RibbonPanel panel)
        {            
            var groupData = new SplitButtonData("SplitGroup1", "Show Message");
            var splitButton = panel.AddItem(groupData) as SplitButton;

            ShowMessageButton[] buttons = GetShowMessageButtons();
            foreach (ShowMessageButton button in buttons)
                AddCommandButton(splitButton, button.Name, button.Text, button.Command, button.SmallBitmapPath, button.LargeBitmapPath, button.Tooltip, button.AddSeparator, button.CurrentButton);            
        }

        private void AddCommandButton(SplitButton splitButton, string name, string text, string command, string smallBitmapPath, string largeBitmapPath, string tooltip, bool addSeparator, bool currentButton)
        {
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            var buttonData = new PushButtonData(name, text, thisAssemblyPath, command);

            var button = splitButton.AddPushButton(buttonData) as PushButton;         
            button.ToolTip = tooltip;            
            button.Image = new BitmapImage(new Uri(smallBitmapPath));            
            button.LargeImage = new BitmapImage(new Uri(largeBitmapPath));

            if (addSeparator)
                splitButton.AddSeparator();

            if (currentButton)
                splitButton.CurrentButton = button;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
