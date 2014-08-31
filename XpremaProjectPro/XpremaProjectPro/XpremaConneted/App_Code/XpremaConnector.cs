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
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public List<Account> getAccounts()
    {
        Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        db.Configuration.LazyLoadingEnabled = false;
        db.Configuration.ProxyCreationEnabled = false;
        return db.Accounts.ToList();
    }

    [WebMethod]
    public List<UserGroup> GetAllGroup()
    {
        return Xprema.Base.Commands.GroupCommand.GetAll();
    }
    [WebMethod]
    public List<Supplier> getallsup()
    {
        return Xprema.Base.Commands.SupplierCommand.GetAll();
    }

    //[WebMethod]
    //public Xprema_PrjectEntities dbX()
    //{

    //    Xprema_PrjectEntities db = new Xprema_PrjectEntities();
    //    db.Configuration.AutoDetectChangesEnabled = false;
    //    db.Configuration.LazyLoadingEnabled = false;
    //    db.Configuration.ProxyCreationEnabled = false;
    //    return db;
    //}

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


#region"Employees"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
     public bool EmployeeAdd(Employee em)
     {
         return EmployeeCommand.addEmployee(em);
     }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool EmployeeEdit(Employee em)
    {
        return EmployeeCommand.EditEmployee (em);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool EmployeeDelete(int ID)
    {
        return EmployeeCommand.DeleteEmployee(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<Employee> EmployeeGetAll()
    {
        return EmployeeCommand.GetAll();
    }
    

    #endregion

#region"Supplier"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool SupplierAdd(Supplier sp)
    {
        return SupplierCommand.newSupplier(sp);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool SupplierEdit(Supplier sp)
    {
        return SupplierCommand.EditSupplier(sp);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool SupplierDelete(int ID)
    {
        return SupplierCommand.DeleteSupplier(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<Supplier> SupplierGetAll()
    {
        return SupplierCommand.GetAll();
    }


    #endregion


#region"Thefinancier"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.Supported)]
    public bool financierAdd(Thefinancier fc)
    {
        return ThefinancierCommand.Newfinancier(fc);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool financierEdit(Thefinancier fc)
    {
        return ThefinancierCommand.Editfinancier(fc);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool financierDelete(int ID)
    {
        return ThefinancierCommand.Deletefinancier(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<Thefinancier> financierGetAll()
    {
        return ThefinancierCommand.GetAll();
    }


    #endregion

#region"ProjectProfile"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.Supported)]
    public bool ProjectProfileAdd(ProjectProfile Pro)
    {
        return ProjectProfileCommand.NewProjectProfile(Pro);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool ProjectProfileEdit(ProjectProfile Pro)
    {
        return ProjectProfileCommand.EditProjectProfile(Pro);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool ProjectProfileDelete(int ID)
    {
        return ProjectProfileCommand.DeleteProjectProfile(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<ProjectProfile> ProjectProfileGetAll()
    {
        return ProjectProfileCommand.GetAll();
    }

    #endregion


#region"SubTheFinancerAndProjectCommand"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.Supported)]
    public bool SubTheFinancerAndProjectCommandAdd(SubTheFinancerAndProject sb)
    {
        return SubTheFinancerAndProjectCommand.NewSubTheFinancerAndProject(sb);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool SubTheFinancerAndProjectEdit(SubTheFinancerAndProject Pro)
    {
        return SubTheFinancerAndProjectCommand.EditSubTheFinancerAndProject(Pro);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool SubTheFinancerAndProjecDelete(int ID)
    {
        return SubTheFinancerAndProjectCommand.DeleteSubTheFinancerAndProject(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<SubTheFinancerAndProject> SubTheFinancerAndProjectGetAll()
    {
        return SubTheFinancerAndProjectCommand.GetAll();
    }

    #endregion


#region"Contract"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.Supported)]
    public bool ContractAdd(Contract Cont)
    {
        return ContractCommand.NewContract(Cont);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool ContractEdit(Contract Cont)
    {
        return ContractCommand.EditContract(Cont);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool ContractDelete(int ID)
    {
        return ContractCommand.DeleteContract(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<Contract> ContractGetAll()
    {
        return ContractCommand.GetAll();
    }

    #endregion

#region"Activity"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.Supported)]
    public bool ActivityAdd(ProjectActivity Activ)
    {
        return ActivityCommand.NewActivity(Activ);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool ActivityEdit(ProjectActivity Activ)
    {
        return ActivityCommand.EditActivity(Activ);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool ActivityDelete(int ID)
    {
        return ActivityCommand.DeleteActivity(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<ProjectActivity> ActivityGetAll()
    {
        return ActivityCommand.GetAll();
    }

    #endregion

#region"SubActivity"
    [WebMethod(true, System.EnterpriseServices.TransactionOption.Supported)]
    public bool subActivityAdd(ProjectSubActivity SActiv)
    {
        return SubActivityCommand.NewSubActivity(SActiv);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool subActivityEdit(ProjectSubActivity SActiv)
    {
        return SubActivityCommand.EditSubActivity(SActiv);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public bool subActivityDelete(int ID)
    {
        return SubActivityCommand.DeleteSubActivity(ID: ID);
    }

    [WebMethod(true, System.EnterpriseServices.TransactionOption.RequiresNew)]
    public List<ProjectSubActivity> subActivityGetAll()
    {
        return SubActivityCommand.GetAll();
    }

    #endregion


}
