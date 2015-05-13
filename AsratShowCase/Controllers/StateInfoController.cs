using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsratShowCase.DAL;
using AsratShowCase.Models;
using PagedList;

namespace AsratShowCase.Controllers
{
    public class StateInfoController : Controller
    {
        private IStateInfoRepository repository;

        public StateInfoController(IStateInfoRepository stateInfoRepository)
        {
            this.repository = stateInfoRepository;
        }

        public ViewResult Index()
        {
            return View();
        }

        // GET: StateInfo
      [ChildActionOnly]
        public PartialViewResult List(string searchStr, int? Page)
        {
            if (searchStr != null)
            {
                Page = 1;
            }
            else
            {
                ViewBag.searchFilter = searchStr;
            }
               var states = from s in repository.StatesInfo
                         select s;
            if (!String.IsNullOrEmpty(searchStr))
            {
                states = states.Where(s => s.name.ToUpper().Contains(searchStr.ToUpper()));
            }
            int pageSize = 1;
            int pageNumber = (Page ?? 1);
            return PartialView(states.ToPagedList(pageNumber, pageSize));
        }

    }
}