using ObuvkaStore.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ObuvkaStore.Models.ViewModels
{
    public class AdminProducts
    {
        [Key]
        public int id { get; set; } 

        [Display (Name = "Название")]
        public string Name { get; set; }
        
        [Display (Name = "Цена")]
        public double price { get; set; }

        [Display(Name = "Картинка")]
        public List<string> picture { get; set; } = new List<string>();

        [Display (Name = "Цвет")]
        public int idColor { get; set; }
        [Display(Name = "Цвет")]
        public string color { get; set; }

        [Display(Name = "Размер")]
        public List<double> Size { get; set; } = new List<double>();

        [Display(Name = "Количество")]
        public List<int> quantity { get; set; } = new List<int>();

        [Display (Name = "Наличие")]
        public bool availability { get; set; }

        [Display (Name = "Для кого")]
        public int idForWhom { get; set; }

        [Display(Name = "Для кого")]
        public string forWhom { get; set; }

        [Display (Name = "Категория")]
        public int idCategory { get; set; }
        [Display(Name = "Категория")]
        public string category { get; set; }

        [Display (Name = "Производитель")]
        public int idProducer { get; set; }
        [Display(Name = "Производитель")]
        public string producer { get; set; }

        [Display (Name = "Сезон")]
        public int idSeason { get; set; }
        [Display(Name = "Сезон")]
        public string season { get; set; }

        [Display (Name = "Материал")]
        public int idMatherial { get; set; }
        [Display(Name = "Материал")]
        public string matherial { get; set; }

        [Display (Name = "Описание")]
        public string description { get; set; }

        public int idProductDescriptions { get; set; }
        public int idProductInfo { get; set; }
        public int idProduct { get; set; }

        public virtual ProductsInfo ProductsInfo { get; set; }
        public virtual ProductsPictures ProductsPictures { get; set; }
        public virtual ProductSizes ProductSizes { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual Colors Colors { get; set; }
        public virtual ForWhoms ForWhoms { get; set; }
        public virtual Matherials Matherials { get; set; }
        public virtual Producers Producers { get; set; }
        public virtual ProductsDescriptions ProductsDescriptions { get; set; }
        public virtual Seasons Seasons { get; set; }
    }
}