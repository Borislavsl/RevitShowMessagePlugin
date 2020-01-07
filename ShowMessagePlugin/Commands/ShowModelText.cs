using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ShowMessageUtilities;

namespace ShowMessagePlugin.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class ShowModelText : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            return RevitAPI.AddModelText(commandData.Application.ActiveUIDocument, "Show Message", message);
        }
    }
}
