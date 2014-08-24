using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Xprema.Base;
using Xprema.Base.Commands;

/// <summary>
/// Summary description for XpremaConnector
/// </summary>
[WebService(Namespace = "Xpro.xprema.net")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class XpremaConnector : System.Web.Services.WebService {

    public XpremaConnector () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod]
    public List<Account> getAccounts()
    {
        Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        db.Configuration.LazyLoadingEnabled=false;
        db.Configuration.ProxyCreationEnabled=false;
        return db.Accounts.ToList();
    }

    [WebMethod]
    public List<UserGroup> GetAllGroup()
    {
      return   Xprema.Base.Commands.GroupCommand.GetAll();
    }
      [WebMethod]
    public List<Supplier> getallsup()
    {
        return Xprema.Base.Commands.SupplierCommand.GetAll();
    }


    //[WebMethod]
    //public  Xprema_PrjectEntities dbX()
    //  {

    //      Xprema_PrjectEntities db = new Xprema_PrjectEntities();
    //      db.Configuration.AutoDetectChangesEnabled = false;
    //      db.Configuration.LazyLoadingEnabled = false;
    //      db.Configuration.ProxyCreationEnabled = false;
    //      return db;
    //  }

#region"Groups"
      [WebMethod(true,System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool GroupAdd(UserGroup g )
      {
          return GroupCommand.NewGroup(g);
      }

      [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool GroupEdit(UserGroup g)
      {
          return GroupCommand.EditGroup(g);
      }
      [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool GroupDelete(int ID)
    {
        return GroupCommand.DeleteGroup( ID);
    }

      [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<UserGroup> GroupGetAll()
    {
        return GroupCommand.GetAll();
    }
#endregion

 #region"Users"
     [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool UserAdd(UserSystem u)
      {
         return  UserCommand.NewUser(u);
      }
     [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool UserEdit(UserSystem u)
    {
        return UserCommand.EditUser(u);
    }

     [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool UserDelete(int ID)
    {
        return UserCommand.DeleteUser(ID: ID);
    }

     [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<UserSystem> UserGetAll()
    {
        return UserCommand.GetAll();
    }
    #endregion


}
