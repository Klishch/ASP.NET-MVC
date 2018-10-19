using ObuvkaStore.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ObuvkaStore.Models.ViewModels
{
    public class Shoes
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Название")]
        public string name { get; set; }

        [Display(Name = "Цена")]
        public double price { get; set; }

        [Display(Name = "Картинка")]
        public List<string> picture { get; set; } = new List<string>();

        [Display(Name = "Цвет")]
        public string color { get; set; }

        [Display(Name = "Размер")]
        public List<double> Size { get; set; } = new List<double>();

        [Display(Name = "Количество")]
        public List<int> quantity { get; set; } = new List<int>();

        [Display(Name = "Наличие")]
        public bool availability { get; set; }

        [Display(Name = "Для кого")]
        public string forWhom { get; set; }

        [Display(Name = "Категория")]
        public string category { get; set; }

        [Display(Name = "Производитель")]
        public string producer { get; set; }

        [Display(Name = "Сезон")]
        public string season { get; set; }

        [Display(Name = "Материал")]
        public string matherial { get; set; }

        [Display(Name = "Описание")]
        public string description { get; set; }

        [Display(Name = "Имя")]
        public List<string> userName { get; set; } = new List<string>();

        [Display(Name = "Фамилия")]
        public List<string> userSurname { get; set; }=new List<string>();

        [Display(Name = "аватар")]
        public List<string> userPicture { get; set; } = new List<string>();

        [Display(Name = "Статус пользователя")]
        public List<string> userStatus { get; set; } = new List<string>();

        
        public virtual ProductsPictures ProductsPictures { get; set; }
        public virtual ProductSizes ProductSizes { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual Colors Colors { get; set; }
        public virtual ForWhoms ForWhoms { get; set; }
        public virtual Matherials Matherials { get; set; }
        public virtual Producers Producers { get; set; }
        public virtual ProductsDescriptions ProductsDescriptions { get; set; }
        public virtual Seasons Seasons { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual UsersInfo UsersInfo { get; set; }
        
    }
}