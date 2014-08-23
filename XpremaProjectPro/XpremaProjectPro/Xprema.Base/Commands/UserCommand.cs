using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
   public class UserCommand
    {
       static Xprema_PrjectEntities db = new Xprema_PrjectEntities();

       public static bool NewUser(UserSystem user)
       {
           try
           {
               db = new Xprema_PrjectEntities();
               db.Configuration.ProxyCreationEnabled = false;
               db.Configuration.LazyLoadingEnabled = false;
               db.UserSystems.Add(user);
               db.SaveChanges();
               return true;

           }
           catch (Exception ex)
           {

               return false;
           }
       }

       public static bool EditUser(UserSystem user)
       {
           try
           {
               db = new Xprema_PrjectEntities();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               var q = db.UserSystems.Where(p => p.Id == user.Id).SingleOrDefault();
               q.UserName = user.UserName;
               q.Password = user.Password;
               q.UserGroup_Id = user.UserGroup_Id;
               db.SaveChanges();
               return true;

           }
           catch (Exception ex)
           {


               return false;
           }
       }

       public static bool DeleteUser(int ID)
       {
           try
           {
               db = new Xprema_PrjectEntities();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               var q = db.UserSystems.Where(p => p.Id == ID).SingleOrDefault();
               db.UserSystems.Remove(q);
               db.SaveChanges();
               return true;
           }
           catch (Exception ex)
           {

               return false;
           }
       }

       public static List<UserSystem> GetAll()
       {
           db = new Xprema_PrjectEntities();
           db.Configuration.LazyLoadingEnabled = false;
           db.Configuration.ProxyCreationEnabled = false;
           return db.UserSystems.ToList();
       }

    }
}
