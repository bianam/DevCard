using Microsoft.AspNetCore.Mvc;
using DevCardProject.Models;
namespace DevCardProject.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Article> articles = new List<Article>()
            {
                new Article(1 , "Asp.net core 7 preview" , "بلاخره بعد از انتشار دات نت 6 همه علاقه مندان منتظر منتشر دات نت 7 بودند که اخر سر مایکروسافت ان را منتشر کرد" ,"blog-post-thumb-1.jpg")
            };
            return View("_Articles", articles);
        }
    }
}
