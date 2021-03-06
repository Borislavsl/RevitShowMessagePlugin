﻿using System.IO;

namespace ShowMessageUtilities
{
    public class PluginCommandButton
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string AssemblyPath { get; set; }
        public string Command { get; set; }
        public string SmallBitmapPath { get; set; }
        public string LargeBitmapPath { get; set; }
        public string Tooltip { get; set; }

        public bool AddSeparator { get; set; }
        public bool CurrentButton { get; set; }
        
        public PluginCommandButton(string name, string text, string assemblyPath, string command, string smallBitmapFileName, string largeBitmapFileName, string tooltip, bool addSeparator = false, bool currentButton = false)
        {
            string bitmapPath = Utils.GetPluginResourceDir();

            Name = name;
            Text = text;
            AssemblyPath = assemblyPath;
            Command = command;
            SmallBitmapPath = Path.Combine(bitmapPath, smallBitmapFileName);
            LargeBitmapPath = Path.Combine(bitmapPath, largeBitmapFileName);
            Tooltip = tooltip;

            AddSeparator = addSeparator;
            CurrentButton = currentButton;
        }
    }
}
