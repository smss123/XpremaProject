using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpremaProjectPro
{
   public class OperationX
    {
        private static string _RequiredField;

        public static string RequiredField
        {
            get {
                OperationX._RequiredField = "This Field Required";
                return OperationX._RequiredField; 
            }
           
        }


        private static string _DeleteMessage;

        public static string DeleteMessage
        {
            get
            {
                OperationX._DeleteMessage = "Delete This Record?";
                return OperationX._DeleteMessage;
            }

        }
    }
}
