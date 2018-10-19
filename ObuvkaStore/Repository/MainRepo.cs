using ObuvkaStore.Models.EntityModels;
using ObuvkaStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObuvkaStore.Repository
{
     public class MainRepo {

        private ObuvkaContext db;
        public MainRepo(ObuvkaContext db)
        {
            this.db = db;
        }

        public List<AdminProducts> MainVM
        {
            get { List <AdminProducts> model = new List<AdminProducts>();

                foreach (var item in db.Products)
                {
                    AdminProducts mod = new AdminProducts();
                    mod.id = item.id;
                    mod.Name = item.name;
                    mod.price = item.price;

                    var pict = from p in db.ProductsPictures
                               where p.idProduct == item.id
                               select p;
                    foreach (var p in pict)
                    {
                        mod.picture.Add(p.picture);
                    }
                    mod.color = item.ProductsInfo.Colors.color_name;
                    var siz = from p in db.ProductSizes
                              where p.idProduct == item.id
                              select p;
                    foreach (var s in siz)
                    {
                        mod.Size.Add(s.size);
                        mod.quantity.Add(s.quantity);
                    }
                    mod.availability = item.ProductsInfo.availability;
                    mod.forWhom = item.ProductsInfo.ForWhoms.whom;
                    mod.category = item.ProductsInfo.Categories.category_name;
                    mod.producer = item.ProductsInfo.Producers.producerName;
                    mod.season = item.ProductsInfo.Seasons.season;
                    mod.matherial = item.ProductsInfo.Matherials.matherial;
                    mod.description = item.ProductsInfo.ProductsDescriptions.description;
                    model.Add(mod);
                };
                return model;
            }
          
        }
        public List<Shoes> AllShoes
        {
            get
            {
                List<Shoes> shoes = new List<Shoes>();
                foreach (var item in db.Products)
                {
                    Shoes sh = new Shoes();
                    sh.id = item.id;
                    sh.name = item.name;
                    sh.price = item.price;

                    var pict = from p in db.ProductsPictures
                               where p.idProduct == item.id
                               select p;
                    foreach (var p in pict)
                    {
                        sh.picture.Add(p.picture);
                    }
                    sh.color = item.ProductsInfo.Colors.color_name;
                    var siz = from p in db.ProductSizes
                              where p.idProduct == item.id
                              select p;
                    foreach (var s in siz)
                    {
                        sh.Size.Add(s.size);
                    }
                    sh.availability = item.ProductsInfo.availability;
                    sh.forWhom = item.ProductsInfo.ForWhoms.whom;
                    sh.category = item.ProductsInfo.Categories.category_name;
                    sh.producer = item.ProductsInfo.Producers.producerName;
                    sh.season = item.ProductsInfo.Seasons.season;
                    sh.matherial = item.ProductsInfo.Matherials.matherial;
                    sh.description = item.ProductsInfo.ProductsDescriptions.description;
                    shoes.Add(sh);
                }
                return shoes;
            }

        }

    }
}