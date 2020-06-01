using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFCore_MySQL_CURD_Sample.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Service;

namespace EFCore_MySQL_CURD_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserInfoService _userInfoService;

        public HomeController(ILogger<HomeController> logger, IUserInfoService userInfoService)
        {
            _logger = logger;
            _userInfoService = userInfoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 新增页
        /// </summary>
        /// <returns></returns>
        public IActionResult AddDialog()
        {
            return View();
        }

        /// <summary>
        /// 编辑页
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  ActionResult DataEditDialog(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
