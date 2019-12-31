using Autodesk.Revit.UI;

namespace UninstallShowMessagePlugin
{
    public class ShowMessageUninstall : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
