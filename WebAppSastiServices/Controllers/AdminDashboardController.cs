using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSastiServices.Models;
using WebAppSastiServices.Models.DB;
    

namespace WebAppSastiServices.Controllers
{
    public class AdminDashboardController : Controller
    {
        SastaServicesDBEntities db = new SastaServicesDBEntities();
        // GET: AdminDashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LatestActOrders()
        {
            db.Configuration.ProxyCreationEnabled = false;

            //---------Single Table Data---------
            //IList<TRNCustomerOrder> orders = db.TRNCustomerOrders.
            //    Where(s => s.STPStatu.Description == "Not Availed").
            //    ToList<TRNCustomerOrder>();
           

            var result = (from o in db.TRNCustomerOrders
                                         join t in db.STPPrefferedTimes on o.preferredTimeID equals t.ID
                                          join s in db.STPServiceTypes on o.ServiceTypeId equals s.ID
                                          join st in db.STPStatus on o.OrderStatusId equals st.ID
                                          select new
                                          {
                                              OrderId = o.OrderId,
                                              CustomerName = o.CustomerName,
                                              Contact = o.Contact,
                                              Address = o.Address,
                                              Description = s.ServiceTypeName,
                                              TimeRange = t.TimeRange,
                                              preferredDate = o.preferredDate.ToString(),
                                              status = st.Description,
                                              CreateOn= o.CreateOn.ToString()
                                          }).ToList();


            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Email()
        {
            return View();
        }
        public ActionResult Vendor()
        {
            return View();
        }
        //public ActionResult Supplier()
        //{
        //    return View();
        //}
        public ActionResult AdminProfile()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult LockScreen()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult InvoiceReport()
        {
            var result = (from o in db.TRNCustomerOrders
                          join t in db.STPPrefferedTimes on o.preferredTimeID equals t.ID
                          join s in db.STPServiceTypes on o.ServiceTypeId equals s.ID
                          join st in db.STPStatus on o.OrderStatusId equals st.ID
                          join f in db.STPServicesFuelTypes on o.FuelTypeId equals f.ID
                          join u in db.STPServicesUnitTypes on o.UnitTypeId equals u.ID
                          select new
                          {
                              OrderId = o.OrderId,
                              CustomerName = o.CustomerName,
                              Contact = o.Contact,
                              Address = o.Address,
                              Description = s.ServiceTypeName,
                              TimeRange = t.TimeRange,
                              preferredDate = o.preferredDate,
                              status = st.Description,
                              FuelType =f.Options,
                              unitType =u.Options
                          }).ToList();
            return View();
        }
        public ActionResult Maps()
        {
            return View();
        }
    }
}