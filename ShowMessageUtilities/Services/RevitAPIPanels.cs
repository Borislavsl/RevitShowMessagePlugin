using System;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI;

namespace ShowMessageUtilities
{
    public static partial class RevitAPI
    {
        public static void AddSplitButtonGroup(RibbonPanel panel, string name, string text, PluginCommandButton[] buttons = null)
        {
            var groupData = new SplitButtonData(name, text);
            var splitButton = panel.AddItem(groupData) as SplitButton;

            if (buttons != null)
            {
                foreach (PluginCommandButton button in buttons)
                    AddCommandButtonToSplitButton(splitButton, button.Name, button.Text, button.AssemblyPath, button.Command, button.SmallBitmapPath, button.LargeBitmapPath, button.Tooltip, button.AddSeparator, button.CurrentButton);
            }
        }

        public static void AddCommandButtonToSplitButton(SplitButton splitButton, string name, string text, string assemblyPath, string command, string smallBitmapPath, string largeBitmapPath, string tooltip, bool addSeparator, bool currentButton)
        {
            var buttonData = new PushButtonData(name, text, assemblyPath, command);

            var button = splitButton.AddPushButton(buttonData) as PushButton;
            button.ToolTip = tooltip;
            button.Image = new BitmapImage(new Uri(smallBitmapPath));
            button.LargeImage = new BitmapImage(new Uri(largeBitmapPath));

            if (addSeparator)
                splitButton.AddSeparator();

            if (currentButton)
                splitButton.CurrentButton = button;
        }
    }
}
