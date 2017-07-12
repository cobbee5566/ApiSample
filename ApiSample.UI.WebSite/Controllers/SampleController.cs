using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ApiSample.BL.Interfaces;
using ApiSample.BL.Services;
using ApiSample.Models;

namespace ApiSample.UI.WebSite.Controllers
{
    public class SampleController : Controller
    {
        public ISampleService SampleService { get; set; }

        /// <summary>
        /// 尚未套用Ioc，暫時直接初始化
        /// </summary>
        public SampleController():this(new SampleService())
        {
        }

        public SampleController(ISampleService sampleService)
        {
            this.SampleService = sampleService;
        }

        // GET: Sample
        public ActionResult Index()
        {
            var data = this.SampleService.GetSamples();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}