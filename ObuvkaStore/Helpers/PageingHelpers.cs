using ObuvkaStore.Models.Pageing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ObuvkaStore.Helpers
{

    public static class PagingHelpers
    {
        //public static MvcHtmlString PageLinks(this HtmlHelper html,
        //    PageInfo pageInfo, Func<int, string> pageUrl)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 1; i <= pageInfo.TotalPages; i++)
        //    {
        //        TagBuilder tag = new TagBuilder("a");
        //        tag.MergeAttribute("href", pageUrl(i));
        //        tag.InnerHtml = i.ToString();
        //        // если текущая страница, то выделяем ее,
        //        // например, добавляя класс
        //        if (i == pageInfo.PageNumber)
        //        {
        //            tag.AddCssClass("selected");
        //            tag.AddCssClass("btn-primary");
        //        }
        //        tag.AddCssClass("btn btn-default");
        //        result.Append(tag.ToString());
        //    }
        //    return MvcHtmlString.Create(result.ToString());
        //}
       
            public static MvcHtmlString PageLinks(this HtmlHelper html, PageInfo pageInfo, Func<int, string> pageUrl)
            {
                List<int> n = new List<int>();
                for (int i = (pageInfo.PageNumber - 4); i < (pageInfo.PageNumber + 5); i++)
                    n.Add(i);
                StringBuilder result = new StringBuilder();
                for (int i = 1; i <= pageInfo.TotalPages; i++)
                {
                    TagBuilder tag = new TagBuilder("a");
                    tag.MergeAttribute("href", pageUrl(i));
                    tag.InnerHtml = i.ToString();
                    int re = n.IndexOf(i);
                    if (re > -1)
                    {
                        if (i == pageInfo.PageNumber)

                        {
                            tag.AddCssClass("selected");
                            tag.AddCssClass("btn btn-primary");
                            tag.MergeAttribute("disabled", "disabled");
                            tag.AddCssClass("noLink");
                        }
                    }
                    else if (i == 1 || i == pageInfo.TotalPages)
                    {
                        tag.AddCssClass("btn-primary");
                    }
                    else if (((i - 1) == 1 && pageInfo.PageNumber > 5) || ((i + 1) == pageInfo.TotalPages && pageInfo.PageNumber < (pageInfo.TotalPages - 5)))
                    {
                        tag.InnerHtml = "...";
                        tag.MergeAttribute("disabled", "disabled");
                        tag.AddCssClass("noLink");
                    }
                    else continue;
                    tag.AddCssClass("btn btn-default");
                    result.Append(tag.ToString());
                }
                return MvcHtmlString.Create(result.ToString());
            }
    }
}