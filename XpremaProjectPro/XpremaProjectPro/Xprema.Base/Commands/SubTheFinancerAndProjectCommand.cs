using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
     public   class SubTheFinancerAndProjectCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        public static bool NewSubTheFinancerAndProject(SubTheFinancerAndProject sub)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.SubTheFinancerAndProjects.Add(sub);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditSubTheFinancerAndProject(SubTheFinancerAndProject sub)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.SubTheFinancerAndProjects.Where(p => p.ID == sub.ID).SingleOrDefault();
                q.ProjectID =sub.ProjectID;
                q.FinacerID = sub.FinacerID;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteSubTheFinancerAndProject(int ID)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.SubTheFinancerAndProjects.Where(p => p.ID == ID).SingleOrDefault();
                db.SubTheFinancerAndProjects.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<SubTheFinancerAndProject> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.SubTheFinancerAndProjects.ToList();
        }
    }
}
