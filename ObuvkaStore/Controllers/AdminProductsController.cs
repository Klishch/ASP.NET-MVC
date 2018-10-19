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
using System.Data.Entity.Validation;
using System.Diagnostics;
using ObuvkaStore.Models.Pageing;
using ObuvkaStore.Repository;

namespace ObuvkaStore.Controllers
{
    public class AdminProductsController : Controller
    {
        private ObuvkaContext db = new ObuvkaContext();
        private MainRepo mainRepo ;

        public AdminProductsController()
        {
            mainRepo = new MainRepo(db);
        }


        [HttpGet]
        public async Task<ActionResult> Index(int page=1)
        {
            List<AdminProducts> model = mainRepo.MainVM;

            #region
            int pageSize = 7;

            IEnumerable<AdminProducts> productsPerPages = model
                .OrderBy(x => x.id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize).ToList();
            PageInfo pageInfo = new PageInfo() { PageNumber = page, PageSize = pageSize, TotalItems = model.Count() };
            IndexViewModel ivm = new IndexViewModel() { PageInfo = pageInfo, PageingAdminProducts = productsPerPages, AllSeasons = db.Seasons };


            #endregion
            return View(ivm);
        }

        // GET: AdminProducts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var prod = db.Products.Find((int)id);
            AdminProducts mod = new AdminProducts();
            mod.id = prod.id;
            mod.Name = prod.name;
            mod.price = prod.price;

            var pict = from p in db.ProductsPictures
                       where p.idProduct == prod.id
                       select p;
            foreach (var p in pict)
            {
                mod.picture.Add(p.picture);
            }
            mod.color = prod.ProductsInfo.Colors.color_name;
            var siz = from p in db.ProductSizes
                      where p.idProduct == prod.id
                      select p;
            foreach (var s in siz)
            {
                mod.Size.Add(s.size);
                mod.quantity.Add(s.quantity);
            }
            mod.availability = prod.ProductsInfo.availability;
            mod.forWhom = prod.ProductsInfo.ForWhoms.whom;
            mod.category = prod.ProductsInfo.Categories.category_name;
            mod.producer = prod.ProductsInfo.Producers.producerName;
            mod.season = prod.ProductsInfo.Seasons.season;
            mod.matherial = prod.ProductsInfo.Matherials.matherial;
            mod.description = prod.ProductsInfo.ProductsDescriptions.description;

            if (mod == null)
            {
                return HttpNotFound();
            }
            return View(mod);
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectList selectColors = new SelectList(db.Colors, "id", "color_name");
            ViewBag.colors = selectColors;
            SelectList selectForWhoms = new SelectList(db.ForWhoms, "id", "whom");
            ViewBag.forWhom = selectForWhoms;
            SelectList selectCategory = new SelectList(db.Categories, "id", "category_name");
            ViewBag.category = selectCategory;
            SelectList selectProducer = new SelectList(db.Producers, "id", "producerName");
            ViewBag.producer = selectProducer;
            SelectList selectSeason = new SelectList(db.Seasons, "id", "season");
            ViewBag.season = selectSeason;
            SelectList selectMatherial = new SelectList(db.Matherials, "id", "matherial");
            ViewBag.matherial = selectMatherial;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind(Include = "id,Name,price,picture,idColor,size,quantity,availability,idForWhom," +
            "idCategory,idProducer,idSeason,idMatherial,description")] AdminProducts adminProducts)
        {
            SelectList selectColors = new SelectList(db.Colors, "id", "color_name");
            ViewBag.colors = selectColors;
            SelectList selectForWhoms = new SelectList(db.ForWhoms, "id", "whom");
            ViewBag.forWhom = selectForWhoms;
            SelectList selectCategory = new SelectList(db.Categories, "id", "category_name");
            ViewBag.category = selectCategory;
            SelectList selectProducer = new SelectList(db.Producers, "id", "producerName");
            ViewBag.producer = selectProducer;
            SelectList selectSeason = new SelectList(db.Seasons, "id", "season");
            ViewBag.season = selectSeason;
            SelectList selectMatherial = new SelectList(db.Matherials, "id", "matherial");
            ViewBag.matherial = selectMatherial;

            if (ModelState.IsValid)
            {
                try
                {
                    db.Products.Add(new Products()
                    {
                        //id= adminProducts.id,
                        name = adminProducts.Name,
                        price = adminProducts.price,
                        ProductsInfo = new ProductsInfo()
                        {
                            idColor = adminProducts.idColor,
                            availability = adminProducts.availability,
                            idForWhom = adminProducts.idForWhom,
                            idCategory = adminProducts.idCategory,
                            idProducer = adminProducts.idProducer,
                            idSeason = adminProducts.idSeason,
                            idMatherial = adminProducts.idMatherial,
                            ProductsDescriptions = new ProductsDescriptions()
                            {
                                description = adminProducts.description
                            }
                        }
                    });

                    foreach (var p in adminProducts.picture)
                    {
                        db.ProductsPictures.Add(new ProductsPictures()
                        {
                            idProduct = adminProducts.idProduct,
                            picture = p.ToString()
                        });
                    }
                    var siz = from p in db.ProductSizes
                              where p.idProduct == adminProducts.idProduct
                              select p;

                    for (int i = 0; i < adminProducts.Size.Count; i++)
                    {
                        db.ProductSizes.Add(new ProductSizes()
                        {
                            idProduct = adminProducts.idProduct,
                            size = adminProducts.Size[i],
                            quantity=adminProducts.quantity[i]
                        });
                    }
                    //foreach (var s in adminProducts.Size)
                    //{
                    //    db.ProductSizes.Add(new ProductSizes()
                    //    {
                    //        idProduct = adminProducts.idProduct,
                    //        size = s
                    //    });
                    //}
                    //foreach (var q in adminProducts.quantity)
                    //{
                    //    db.ProductSizes.Add(new ProductSizes()
                    //    {
                    //        idProduct = adminProducts.idProduct,
                    //        quantity = q
                    //    });
                    //}
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: AdminProducts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            SelectList selectColors = new SelectList(db.Colors, "id", "color_name");
            ViewBag.colors = selectColors;
            SelectList selectForWhoms = new SelectList(db.ForWhoms, "id", "whom");
            ViewBag.forWhom = selectForWhoms;
            SelectList selectCategory = new SelectList(db.Categories, "id", "category_name");
            ViewBag.category = selectCategory;
            SelectList selectProducer = new SelectList(db.Producers, "id", "producerName");
            ViewBag.producer = selectProducer;
            SelectList selectSeason = new SelectList(db.Seasons, "id", "season");
            ViewBag.season = selectSeason;
            SelectList selectMatherial = new SelectList(db.Matherials, "id", "matherial");
            ViewBag.matherial = selectMatherial;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var prod = db.Products.Find((int)id);
            AdminProducts mod = new AdminProducts();
            mod.Name = prod.name;
            mod.price = prod.price;

            var pict = from p in db.ProductsPictures
                       where p.idProduct == prod.id
                       select p;
            foreach (var p in pict)
            {
                mod.picture.Add(p.picture);
            }
            mod.idColor = prod.ProductsInfo.idColor;
            var siz = from p in db.ProductSizes
                      where p.idProduct == prod.id
                      select p;
            foreach (var s in siz)
            {
                mod.Size.Add(s.size);
                mod.quantity.Add(s.quantity);
            }
            mod.availability = prod.ProductsInfo.availability;
            mod.idForWhom = prod.ProductsInfo.ForWhoms.id;
            mod.idCategory = prod.ProductsInfo.Categories.id;
            mod.idProducer = prod.ProductsInfo.Producers.id;
            mod.idSeason = prod.ProductsInfo.Seasons.id;
            mod.idMatherial = prod.ProductsInfo.Matherials.id;
            mod.description = prod.ProductsInfo.ProductsDescriptions.description;

            if (mod == null)
            {
                return HttpNotFound();
            }

            return View(mod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,Name,price,picture,idColor,size,quantity,availability,idForWhom," +
            "idCategory,idProducer,idSeason,idMatherial,description")] AdminProducts adminProducts)
        {
            SelectList selectColors = new SelectList(db.Colors, "id", "color_name");
            ViewBag.colors = selectColors;
            SelectList selectForWhoms = new SelectList(db.ForWhoms, "id", "whom");
            ViewBag.forWhom = selectForWhoms;
            SelectList selectCategory = new SelectList(db.Categories, "id", "category_name");
            ViewBag.category = selectCategory;
            SelectList selectProducer = new SelectList(db.Producers, "id", "producerName");
            ViewBag.producer = selectProducer;
            SelectList selectSeason = new SelectList(db.Seasons, "id", "season");
            ViewBag.season = selectSeason;
            SelectList selectMatherial = new SelectList(db.Matherials, "id", "matherial");
            ViewBag.matherial = selectMatherial;

            if (ModelState.IsValid)
            {
                try
                {
                    await Delete(adminProducts.id);
                    Create();


                    //var prod = db.Products.Find(adminProducts.id);
                    //ProductsViewModel mod = new ProductsViewModel();
                    //prod.Name_ua = adminProducts.Name_ua;
                    //prod.Name_ru = adminProducts.Name_ru;
                    //prod.Name_eng = adminProducts.Name_eng;
                    //prod.price = adminProducts.price;


                    //prod.ProductsInfo.idColor = adminProducts.idColor;
                    ////prod.ProductSizes.Clear();
                    //foreach (var s in adminProducts.Size)
                    //{
                    //    db.ProductSizes.Add(new ProductSizes()
                    //    {
                    //        idProduct= adminProducts.idProduct,
                    //        size=s
                    //    });
                    //}
                    //foreach (var q in adminProducts.quantity)
                    //{
                    //    db.ProductSizes.Add(new ProductSizes()
                    //    {
                    //        idProduct = adminProducts.idProduct,
                    //        quantity = q
                    //    });
                    //}

                    ////var siz = from p in db.ProductSizes
                    ////          where p.idProduct == adminProducts.id
                    ////          select p;
                    ////foreach (var s in siz)
                    ////{
                    ////    prod.Size.Add(s.size);
                    ////    prod.quantity.Add(s.quantity);
                    ////}
                    //prod.ProductsInfo.availability = adminProducts.availability;
                    //prod.ProductsInfo.idForWhom = adminProducts.idForWhom;
                    //prod.ProductsInfo.idCategory = adminProducts.idCategory;
                    //prod.ProductsInfo.idProducer = adminProducts.idProducer;
                    //prod.ProductsInfo.idSeason = adminProducts.idSeason;
                    //prod.ProductsInfo.idMatherial = adminProducts.idMatherial;
                    //prod.ProductsInfo.ProductsDescriptions.description_ua = adminProducts.description_ua;
                    //prod.ProductsInfo.ProductsDescriptions.description_ru = adminProducts.description_ru;
                    //prod.ProductsInfo.ProductsDescriptions.description_eng = adminProducts.description_eng;
                    //#region
                    ////Products pr = db.Products.Find(adminProducts.id);
                    ////pr.Name_ua = adminProducts.Name_ua;
                    ////pr.Name_ru = adminProducts.Name_ru;
                    ////pr.Name_eng = adminProducts.Name_eng;
                    ////pr.price = adminProducts.price;
                    ////ProductsInfo prodInfo = db.ProductsInfo.Find(adminProducts.idProductInfo);
                    ////prodInfo.idColor = adminProducts.Colors.id;
                    ////prodInfo.availability = adminProducts.availability;
                    ////prodInfo.idForWhom = adminProducts.idForWhom;
                    ////prodInfo.idCategory = adminProducts.idCategory;
                    ////prodInfo.idProducer = adminProducts.idProducer;
                    ////prodInfo.idSeason = adminProducts.idSeason;
                    ////prodInfo.idMatherial = adminProducts.idMatherial;
                    ////ProductsDescriptions prodDescr = db.ProductsDescriptions.Find(adminProducts.idProductDescriptions);
                    ////prodDescr.description_ua = adminProducts.description_ua;
                    ////prodDescr.description_ru = adminProducts.description_ru;
                    ////prodDescr.description_eng = adminProducts.description_eng;
                    ////ProductsPictures prodPic = db.ProductsPictures.Find(adminProducts.id);
                    ////ProductSizes prodSize = db.ProductSizes.Find(adminProducts.id);

                    ////foreach (var p in adminProducts.picture)
                    ////{
                    ////    prodPic.picture = p;
                    ////}
                    ////foreach (var s in adminProducts.Size)
                    ////{
                    ////    prodSize.size = s;
                    ////}
                    ////foreach (var q in adminProducts.quantity)
                    ////{
                    ////    prodSize.quantity = q;
                    ////}
                    ////db.Entry(pr).State = EntityState.Modified;
                    ////db.Entry(prodInfo).State = EntityState.Modified;
                    ////db.Entry(prodDescr).State = EntityState.Modified;
                    ////db.Entry(prodPic).State = EntityState.Modified;
                    ////db.Entry(prodSize).State = EntityState.Modified;
                    //#endregion
                    //db.Entry(prod).State = EntityState.Modified;
                    ////var pict = from p in db.ProductsPictures.AsEnumerable()
                    ////           where p.idProduct == adminProducts.id
                    ////           select p;
                    ////foreach (var p in db.ProductsPictures.Where(x => x.idProduct== adminProducts.id))
                    ////{
                    ////    db.Products.Find(pict);
                    ////    db.Products.Remove(pict);
                    ////}

                    ////db.Entry(prodInfo).State = EntityState.Modified;
                    ////db.Entry(prodDescr).State = EntityState.Modified;
                    ////db.Entry(prodPic).State = EntityState.Modified;
                    ////db.Entry(prodSize).State = EntityState.Modified;
                    ////await db.SaveChangesAsync();
                    ////foreach (var p in pict)
                    ////{
                    ////    foreach (var pp in adminProducts.picture)
                    ////    {
                    ////        if (!p.Equals(pp))
                    ////        {
                    ////            db.ProductsPictures.Add(new ProductsPictures()
                    ////            {
                    ////                idProduct = adminProducts.id,
                    ////                picture = pp
                    ////            });
                    ////        }
                    ////    }
                    ////}
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }

                return RedirectToAction("Index");
            }
            return View(adminProducts);
        }

        // GET: AdminProducts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var prod = db.Products.Find((int)id);
            AdminProducts mod = new AdminProducts();
            mod.id = prod.id;
            mod.Name = prod.name;
            mod.price = prod.price;

            var pict = from p in db.ProductsPictures
                       where p.idProduct == prod.id
                       select p;
            foreach (var p in pict)
            {
                mod.picture.Add(p.picture);
            }
            mod.color = prod.ProductsInfo.Colors.color_name;
            var siz = from p in db.ProductSizes
                      where p.idProduct == prod.id
                      select p;
            foreach (var s in siz)
            {
                mod.Size.Add(s.size);
                mod.quantity.Add(s.quantity);
            }
            mod.availability = prod.ProductsInfo.availability;
            mod.forWhom = prod.ProductsInfo.ForWhoms.whom;
            mod.category = prod.ProductsInfo.Categories.category_name;
            mod.producer = prod.ProductsInfo.Producers.producerName;
            mod.season = prod.ProductsInfo.Seasons.season;
            mod.matherial = prod.ProductsInfo.Matherials.matherial;
            mod.description = prod.ProductsInfo.ProductsDescriptions.description;

            if (mod == null)
            {
                return HttpNotFound();
            }
            return View(mod);
        }
        // POST: AdminProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var prod = db.Products.Find(id);

            db.Products.Remove(prod);
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
