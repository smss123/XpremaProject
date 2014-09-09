using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpremaProjectPro.AddProjectSenario.ProjectPlane
{
   public class SubActivityObj
    {
        public int ID { get; set; }
        public string  SubActiveName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public int TimeLine { get; set; }
        public double  TotalCost { get; set; }
        public int ActivateID { get; set; }
    }
}
