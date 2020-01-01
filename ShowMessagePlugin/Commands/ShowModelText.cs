using System;
using System.Linq;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.Creation;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ShowMessagePlugin
{
    [Transaction(TransactionMode.Manual)]
    public class ShowModelText : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                UIDocument uiDoc = commandData.Application.ActiveUIDocument;
                var familyDoc = uiDoc.Document;
                View view = uiDoc.ActiveView;

                using (var tx = new Transaction(familyDoc))
                {
                    tx.Start("Create Model Text");
                    var modelTextType = new FilteredElementCollector(familyDoc).OfClass(typeof(ModelTextType)).First() as ModelTextType;
                    FamilyItemFactory factory = familyDoc.FamilyCreate;
                    try
                    {
                        factory.NewModelText("Show Message", modelTextType, view.SketchPlane, new XYZ(0.0, 0.0, 0.0), HorizontalAlign.Left, 5.0);
                    }
                    catch (Exception ex)
                    {
                        message = ex.Message;
                        return Result.Failed;
                    }
                    finally
                    {
                        tx.Commit();
                    }
                }

                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}
