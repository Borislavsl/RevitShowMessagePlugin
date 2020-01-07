using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ShowMessagePlugin.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class ShowMessageBox : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Plugin", "Show Message Plugin");

            return Result.Succeeded;
        }
    }
}
