using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
    public class ContractCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        public static bool NewContract(Contract Ct)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.Contracts.Add(Ct);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool EditContract(Contract Ct)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Contracts.Where(p => p.ID == Ct.ID).SingleOrDefault();
                q.Employee_ID = Ct.Employee_ID;
                q.ProjectProfile_ID = Ct.ProjectProfile_ID;
                q.SelaryAmount = Ct.SelaryAmount;
                q.StartDate = Ct.StartDate;
                q.EndDate = Ct.EndDate;
                q.Status = Ct.Status;
                q.UserID = Ct.UserID;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteContract(int ID)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Contracts.Where(p => p.ID == ID).SingleOrDefault();
                db.Contracts.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<Contract> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.Contracts.ToList();
        }
    }
}
