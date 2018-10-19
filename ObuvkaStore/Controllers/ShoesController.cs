using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ObuvkaStore.Models.EntityModels;
using ObuvkaStore.Models.ViewModels;
using ObuvkaStore.Models.Pageing;
using ObuvkaStore.Repository;

namespace ObuvkaStore.Controllers
{
    public class ShoesController : Controller
    {
        private ObuvkaContext db = new ObuvkaContext();
        private MainRepo mainRepo;

        public ShoesController()
        {
            mainRepo = new MainRepo(db);
        }


        // GET: Shoes
        public async Task<ActionResult> Index(int page = 1)
        {
            List<Shoes> shoes = mainRepo.AllShoes;
            #region
            int pageSize = 8;

            IEnumerable<Shoes> shoesPerPages = shoes
                .OrderBy(x => x.id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize).ToList();
            PageInfo pageInfo = new PageInfo() { PageNumber = page, PageSize = pageSize, TotalItems = shoes.Count() };
            IndexViewModel ivm = new IndexViewModel()
            {
                PageInfo = pageInfo,
                PageingShoes = shoesPerPages,
                AllSeasons = db.Seasons,
                AllCategories = db.Categories,
                AllColors = db.Colors,
                AllMatherials = db.Matherials,
                AllSizes = db.ProductSizes
            };
            #endregion
            return View(ivm);
        }

        //// GET: Shoes/Details/5
        //public async Task<ActionResult> Details(string check)
        //{
        //    List<Shoes> shoes = mainRepo.AllShoes;
        //    switch (check)
        //    {
        //        case "category":
        //       var cat = from p in shoes
        //                  where p.Categories.category_name == category
        //                 select p;
        //            break;
        //        case "season":
                    
        //            break;
        //        case "matherial":

        //            break;
        //        case "size":

        //            break;
        //        case "color":

        //            break;
        //        default:
                    
        //            break;
        //    }
            

        //    // остальной код метода
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    //var shoe = shoes.Where(x => x.id == id);
        //    ////var shoe = from s in shoes
        //    ////             where s.id == id
        //    ////             select s;
        //    //if (shoes == null)
        //    //{
        //    //    return HttpNotFound();
        //    //}
        //    return View();
        //}

        // GET: Shoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<ActionResult> ShowShoes(int page=1/*, string[] arr*/)
        //{
        //List<Shoes> shoes = new List<Shoes>();

        //foreach (var item in db.Products)
        //{
        //    Shoes sh = new Shoes();
        //    sh.id = item.id;
        //    sh.name = item.name;
        //    sh.price = item.price;

        //    var pict = from p in db.ProductsPictures
        //               where p.idProduct == item.id
        //               select p;
        //    foreach (var p in pict)
        //    {
        //        sh.picture.Add(p.picture);
        //    }
        //    sh.color = item.ProductsInfo.Colors.color_name;
        //    var siz = from p in db.ProductSizes
        //              where p.idProduct == item.id
        //              select p;
        //    foreach (var s in siz)
        //    {
        //        sh.Size.Add(s.size);
        //    }
        //    sh.availability = item.ProductsInfo.availability;
        //    sh.forWhom = item.ProductsInfo.ForWhoms.whom;
        //    sh.category = item.ProductsInfo.Categories.category_name;
        //    sh.producer = item.ProductsInfo.Producers.producerName;
        //    sh.season = item.ProductsInfo.Seasons.season;
        //    sh.matherial = item.ProductsInfo.Matherials.matherial;
        //    sh.description = item.ProductsInfo.ProductsDescriptions.description;
        //    shoes.Add(sh);
        //}
        //#region
        //int pageSize = 8;

        //IEnumerable<Shoes> shoesPerPages = shoes
        //    .OrderBy(x => x.id)
        //    .Skip((page - 1) * pageSize)
        //    .Take(pageSize).ToList();
        //PageInfo pageInfo = new PageInfo() { PageNumber = page, PageSize = pageSize, TotalItems = shoes.Count() };
        //IndexViewModel ivm = new IndexViewModel() { PageInfo = pageInfo, PageingShoes = shoesPerPages };
        //#endregion
        //return View(ivm);
        //}

        // GET: Shoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoes shoes = await db.Shoes.FindAsync(id);
            if (shoes == null)
            {
                return HttpNotFound();
            }
            return View(shoes);
        }

        // POST: Shoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,Name_ru,price,color,availability,forWhom,category,producer,season,matherial,description_ru")] Shoes shoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoes).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(shoes);
        }

        // GET: Shoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoes shoes = await db.Shoes.FindAsync(id);
            if (shoes == null)
            {
                return HttpNotFound();
            }
            return View(shoes);
        }

        // POST: Shoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Shoes shoes = await db.Shoes.FindAsync(id);
            db.Shoes.Remove(shoes);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
