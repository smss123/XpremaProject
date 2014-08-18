using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
    public Xprema.Base.Xprema_PrjectEntities DataSource()
    {
        return new Xprema.Base.Xprema_PrjectEntities();
    }
    
}
