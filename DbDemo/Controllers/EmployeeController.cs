using DbDemo.ADO;
using DbDemo.Models;
using System.Linq;
using System.Web.Mvc;

namespace DbDemo.Controllers
{
    public class EmployeeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Employee
        public ActionResult Index()
        {
            Ado obj = new Ado();

            int i = obj.InsertData();
            Emplyee em = new Emplyee();
            em.EmplyeeId = 1;
            em.EmpName = "ssssss";
            i = obj.UpdateData(em);

            int j = obj.DeleteData(3);


            var adaptor = obj.getEmployeeBYAdaptor();
            var empFromDataReader = obj.getEmployee();

            var emp = db.Emplyees.ToList();
            return View(emp);
        }

        // GET: Employee/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Employee/Create
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View(new Emplyee());
        //}

        //// POST: Employee/Create
        //[HttpPost]
        //public ActionResult Create(Emplyee emplyee)
        //{
        //    try
        //    {
        //        db.Emplyees.Add(emplyee);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View(emplyee);
        //    }
        //}

        //// GET: Employee/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    var emp = db.Emplyees.Single(x => x.EmplyeeId == id);// .Select(x => x.EmplyeeId == id).SingleOrDefault();
        //    return View(emp);
        //}

        //// POST: Employee/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, Emplyee emplyee)
        //{
        //    try
        //    {

              



        //        db.Entry(emplyee).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();

                
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Employee/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    var emp = db.Emplyees.Single(x => x.EmplyeeId == id);// .Select(x => x.EmplyeeId == id).SingleOrDefault();

        //    return View(emp);
           
        //}

        //// POST: Employee/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, Emplyee emplyee)
        //{
        //    try
        //    {
               
        //        emplyee.EmplyeeId = id;

        //        db.Entry(emplyee).State = System.Data.Entity.EntityState.Deleted;
        //        db.SaveChanges();

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
            }
        }
    }
}
