using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpremaProjectPro.AddProjectSenario.ProjectPlane
{
   public class ActivateObj
    {
        public int ID { get; set; }
        public string  ActivityName { get; set; }
        public string  Description { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public double  TotalCost { get; set; }
    }
}
