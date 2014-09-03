using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpremaProjectPro.XpConnected;
namespace XpremaProjectPro.AddProjectSenario
{
    internal class XProjectSenario
    {
        public static  ProjectProfile ProjectSenarioSetting { get; set; }
        public static List<Fin> ProjectFinceer { get; set; }
        public static void ini()
        {
            ProjectSenarioSetting = new ProjectProfile();
        }
        private static XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public static void Commit()
        {
            proxy.ProjectProfileAdd(ProjectSenarioSetting);
        }
    }
}
