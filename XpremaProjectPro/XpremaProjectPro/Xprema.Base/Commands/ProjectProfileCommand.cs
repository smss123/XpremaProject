using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
     public  class ProjectProfileCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        public static bool NewProjectProfile(ProjectProfile pro)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.ProjectProfiles.Add(pro);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditProjectProfile(ProjectProfile pro)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectProfiles.Where(p => p.ID == pro.ID).SingleOrDefault();
                q.ProjectName = pro.ProjectName;
                q.ProjectDescription = pro.ProjectDescription;
                q.StartDate = pro.StartDate;
                q.EndDate = pro.EndDate;
                q.Status = q.Status;
                q.progress = q.progress;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }
        public static bool DeleteProjectProfile(int ID)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.ProjectProfiles.Where(p => p.ID == ID).SingleOrDefault();
                db.ProjectProfiles.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static List<ProjectProfile> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.ProjectProfiles.ToList();
        }
    }
}
