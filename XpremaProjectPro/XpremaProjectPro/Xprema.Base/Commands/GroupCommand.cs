using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
   public class GroupCommand
    {
       static Xprema_PrjectEntities db = new Xprema_PrjectEntities(); 
       public static bool NewGroup(UserGroup g)
       {
           try 
	        {	
               db = new Xprema_PrjectEntities();
               db.Configuration.ProxyCreationEnabled=false;
               db.Configuration.LazyLoadingEnabled=false;
               db.UserGroups.Add(g);
               db.SaveChanges();
               return true;
		
	        }
	        catch (Exception ex)
	        {

                return false;
	        }
       }
       public static bool EditGroup(UserGroup g)
       {
           try
           {
               db = new Xprema_PrjectEntities();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               var q = db.UserGroups.Where(p => p.Id == g.Id).SingleOrDefault();
               q.GroupName = g.GroupName;
               q.GroupDescription = g.GroupDescription;
               db.SaveChanges();
               return true;

           }
           catch (Exception ex)
           {


               return false;
           }
       }

       public static bool DeleteGroup(int ID)
       {
           try
           {
                db = new Xprema_PrjectEntities();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               var q = db.UserGroups.Where(p => p.Id == ID).SingleOrDefault();
               db.UserGroups.Remove(q);
               db.SaveChanges();
               return true;
           }
           catch (Exception ex)
           {

               return false;
           }
       }

       public static List<UserGroup> GetAll()
       {
           db = new Xprema_PrjectEntities();
           db.Configuration.LazyLoadingEnabled = false;
           db.Configuration.ProxyCreationEnabled = false;
           return db.UserGroups.ToList();
       }

    }
}
