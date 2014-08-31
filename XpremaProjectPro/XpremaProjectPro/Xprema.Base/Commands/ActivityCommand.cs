using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
   public class ActivityCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        public static bool NewActivity(ProjectActivity Actv)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.ProjectActivities.Add(Actv);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditActivity(ProjectActivity Actv)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectActivities.Where(p => p.ID == Actv.ID).SingleOrDefault();
                q.ProjectProfile_ID = Actv.ProjectProfile_ID;
                q.ActivityName = Actv.ActivityName;
                q.Description = Actv.Description;
                q.StartDate = Actv.StartDate;
                q.EndDate = Actv.EndDate;
                q.TotalCost = Actv.TotalCost;
                q.Status = Actv.Status;
                q.Progress = Actv.Progress;
                
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteActivity(int ID)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectActivities.Where(p => p.ID == ID).SingleOrDefault();
                db.ProjectActivities.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<ProjectActivity> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.ProjectActivities.ToList();
        }
    }
}
