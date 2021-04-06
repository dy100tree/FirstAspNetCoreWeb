using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstAspNetCoreWeb.Models;

namespace FirstAspNetCoreWeb.Controllers
{
    public class ContentController : Controller
    {
        //public IActionResult Index()
        //{
        //    var contents = new List<Content>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        contents.Add(new Content() { Id = i, title = $"这是标题{i}", content = $"这是内容{i}", status = 1, add_time = DateTime.Now.AddDays(-i), modify_time = DateTime.Now });
        //    }
        //    return View(new ContentViewModel() { Contents = contents });
        //}

        //private readonly Content contents;
        //public ContentController(Microsoft.Extensions.Options.IOptions<Content> option)
        //{
        //    contents = option.Value;
        //}
        //public IActionResult Index()
        //{
        //    //var contents = new List<Content>();
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    contents.Add(new Content() { Id = i, title = $"这是标题{i}", content = $"这是内容{i}", status = 1, add_time = DateTime.Now.AddDays(-i), modify_time = DateTime.Now });
        //    //}
        //    return View(new ContentViewModel()
        //    {
        //        Contents = new List<Content> { contents }
        //    });
        //}

        /// <summary>
        /// 容器创建的实例是有生命周期的
        /// 1.Transient:第一次访问都会创建一个新的实例
        /// 2.Scoped:在同一个Scope内只初始化一个实例，可以理解为(每一个Request级别只创建一个实例，同一个HttpRequest会在一个scope内)
        /// 3.Singleton：整个应用程序生命周期内只创建一个实例
        /// </summary>
        private readonly List<Content> contents;
        public ContentController(Microsoft.Extensions.Options.IOptions<List<Content>> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 0; i < 10; i++)
            //{
            //    contents.Add(new Content() { Id = i, title = $"这是标题{i}", content = $"这是内容{i}", status = 1, add_time = DateTime.Now.AddDays(-i), modify_time = DateTime.Now });
            //}
            return View(new ContentViewModel()
            {
                Contents = contents
            });
        }
    }
}