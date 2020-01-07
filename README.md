# RevitShowMessagePlugin


Prerequisites

1. Installed Revit 2020

2. After installing the plugin, check in Properties Debug section of ShowMessagePlugin project the
"Start external program" option to start C:\Program Files\Autodesk\Revit 2020\Revit.exe.
Do the same with and UninstallShowMessagePlugin project.

Start the project ShowMessagePlugin.

It creates the plugin in $(AppData)Autodesk\Revit\Addins\2020\ShowMessagePlugin\ folder and subfolders (by post build events), and starts Revit. ShowMesssagePlugin.dll is automatically executed.

Open an existing Family file (for example from C:\Program Files\Autodesk\Revit 2020\Samples\ folder) and activate Add-ins tab.
A new panel Show Message containing a split button with two command buttons are added in Add-ins. Clicking on them, they execute respectively:

- A command which displays a Message box.

- A command which adds a 'Show Message' Model Text to the opened family document.

Try both of them.

Close Revit.

To uninstall the plugin, start UninstallShowMessagePlugin project..

The $(AppData)Autodesk\Revit\Addins\2020\ShowMessagePlugin\ folder  and the ShowMessagePlugin.addin file are deleted by pre-build events.
In this way, the whole plugin is uninstalled.


