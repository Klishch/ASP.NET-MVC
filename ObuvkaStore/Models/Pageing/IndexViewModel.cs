using ObuvkaStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObuvkaStore.Models.EntityModels;

namespace ObuvkaStore.Models.Pageing
{
    public class IndexViewModel
    {
        public IEnumerable<AdminProducts> PageingAdminProducts { get; set; }
        public IEnumerable<Shoes> PageingShoes { get; set; }
        public IEnumerable<Seasons> AllSeasons { get; set; }
        public IEnumerable<Categories> AllCategories { get; set; }
        public IEnumerable<Matherials> AllMatherials { get; set; }
        public IEnumerable<ProductSizes> AllSizes { get; set; }
        public IEnumerable<Colors> AllColors { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}