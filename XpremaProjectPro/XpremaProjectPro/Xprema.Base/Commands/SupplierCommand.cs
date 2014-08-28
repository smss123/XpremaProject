using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Base.Commands
{
  public  class SupplierCommand
    {
        static Xprema_PrjectEntities db = new Xprema_PrjectEntities();
        public static bool newSupplier(Supplier Sup)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                db.Suppliers.Add(Sup);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static bool EditSupplier(Supplier Sup)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Suppliers.Where(p => p.ID == Sup.ID).SingleOrDefault();
                q.name = Sup.name;
                q.SuppliersNatural = Sup.SuppliersNatural;
                q.PhoneNumber = Sup.PhoneNumber;
                q.Fax = Sup.Fax;
                q.Email = Sup.Email;
                q.Adderss = Sup.Adderss;               
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public static bool DeleteSupplier(int ID)
        {
            try
            {
                db = new Xprema_PrjectEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Suppliers.Where(p => p.ID == ID).SingleOrDefault();
                db.Suppliers.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static List<Supplier> GetAll()
        {
            db = new Xprema_PrjectEntities();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.ProxyCreationEnabled = false;
            return db.Suppliers.ToList();
        }
    }
}
