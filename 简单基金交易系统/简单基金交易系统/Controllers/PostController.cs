using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 简单基金交易系统.Models;

namespace 简单基金交易系统.Controllers
{
    public class PostController : Controller
    {

        public static List<Post> posts = new List<Post>()
        {
            new Post()
            {
                Id=1,Author = "wangdi's",Content = "文章1内容",
                Createdata =DateTime.Now,ModifDate = DateTime.Now,
                Title = "文章1"
            }
        };
        // GET: Post
        /// <summary>
        /// 获取某个东西
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Posts = posts;
            return View();
        }

        /// <summary>
        /// 获取某个内容
        /// </summary>
        /// <returns></returns>
        public ActionResult Get(int Id)
        {
            var post = posts.Where(p => p.Id == Id).FirstOrDefault();
            if (post == null)
            {
                return HttpNotFound();
            }

            ViewBag.Post = post;
            return View();
        }
    }
}