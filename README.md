# RevitShowMessagePlugin


Prerequisites

1. Installed Revit 2020

2. In Properties Debug section of both projects ShowMessagePlugin and UninstallShowMessagePlugin,
"Start external program" should be checked with C:\Program Files\Autodesk\Revit 2020\Revit.exe

Start the project ShowMessagePlugin.

It creates the plugin in $(AppData)Autodesk\Revit\Addins\2020\ShowMessagePlugin\ folder and subfolders (by post build events), and starts Revit. ShowMesssagePlugin.dll is automatically executed.

A new panel Show Message containing a split button with two command buttons are added in Add-ins. Clicking on them, they execute respectively:

- A command which displays a Windows form.

- A command which adds a 'Show Message' Model Text to the opened family document ShowMesssageFamily.rfa

Try both of them.

Close Revit.

To uninstall the plugin, start UninstallShowMessagePlugin project..

The $(AppData)Autodesk\Revit\Addins\2020\ShowMessagePlugin\ folder  and the ShowMessagePlugin.addin file are deleted by pre-build events.
In this way, the whole plugin is uninstalled.


