using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
    public  class SubActivityCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        public static bool NewSubActivity(ProjectSubActivity SActv)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.ProjectSubActivities.Add(SActv);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditSubActivity(ProjectSubActivity SActv)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectSubActivities.Where(p => p.ID == SActv.ID).SingleOrDefault();
                q.ProjectActivity_ID = SActv.ProjectActivity_ID;
                q.SubActivityName = SActv.SubActivityName;
                q.Description = SActv.Description;
                q.Startdate = SActv.Startdate;
                q.enddate = SActv.enddate;
                q.TotalCost = SActv.TotalCost;
                q.Status = SActv.Status;
                q.Persentage = SActv.Persentage;

                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteSubActivity(int ID)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectSubActivities.Where(p => p.ID == ID).SingleOrDefault();
                db.ProjectSubActivities.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<ProjectSubActivity> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.ProjectSubActivities.ToList();
        }

    }
}
