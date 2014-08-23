using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
    public  class ThefinancierCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();

        public static bool NewUser(Thefinancier finc)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.Thefinanciers.Add(finc);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static bool EditUser(Thefinancier finc)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Thefinanciers.Where(p => p.ID == finc.ID).SingleOrDefault();
                q.financiername = finc.financiername;
                q.agentName = finc.agentName;
                q.PhoneNumber = finc.PhoneNumber;
                q.Fax = finc.Fax;
                q.Email = finc.Email;
                q.Adderss = finc.Adderss;
               

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
                var q = db.Thefinanciers.Where(p => p.ID == ID).SingleOrDefault();
                db.Thefinanciers.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<Thefinancier> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.Thefinanciers.ToList();
        }
    }
}
