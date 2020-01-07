using System;
using System.Linq;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Creation;

namespace ShowMessageUtilities
{
    public static partial class RevitAPI
    {
        public static Result AddModelText(UIDocument uiDoc, string text, string message)
        {
            var familyDoc = uiDoc.Document;
            SketchPlane sketchPlane = uiDoc.ActiveView.SketchPlane;

            using (var tx = new Transaction(familyDoc))
            {
                tx.Start("Create Model Text");
                var modelTextType = new FilteredElementCollector(familyDoc).OfClass(typeof(ModelTextType)).First() as ModelTextType;
                FamilyItemFactory factory = familyDoc.FamilyCreate;
                try
                {
                    factory.NewModelText(text, modelTextType, sketchPlane, new XYZ(0.0, 0.0, 0.0), HorizontalAlign.Left, 5.0);
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
    }
}
