using AppraisalSystem.Utility;
using System.Configuration;

namespace Appraisal_System {
        internal static class Program {
                [STAThread]
                static void Main() {
                        SqlHelper.ConStr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                        ApplicationConfiguration.Initialize();
                        Application.Run(new FrmMain());
                }
        }
}