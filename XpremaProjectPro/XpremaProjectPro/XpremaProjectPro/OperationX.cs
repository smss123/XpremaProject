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
                OperationX._DeleteMessage = "Do You Want To Delete This Record?";
                return OperationX._DeleteMessage;
            }

        }


        private static string _DeletedMessage;

        public static string DeletedMessage
        {
            get
            {
                OperationX._DeletedMessage = "Record Deleted";
                return OperationX._DeletedMessage;
            }

        }

        private static readonly string enterName = "Please enter the name";

        public static string EnterName
        {
            get { return OperationX.enterName; }
        }

        private static readonly string saveMessage = "Do You Want To Save Changes";

        public static string SaveMessage
        {
            get { return OperationX.saveMessage; }

        }

        private static readonly string editMessage = "Save Changes Done";

        public static string EditMessage
        {
            get { return OperationX.editMessage; }

        }

        private static readonly string saveMessageDone = "Add Record Done";

        public static string SaveMessageDone
        {
            get { return OperationX.saveMessageDone; }

        }


    }
}
