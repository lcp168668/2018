using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using CTN_test.Models;

namespace CTN_test.Controllers
{
    public class HomeController : ApiController
    {
        #region 测试数据
        [Route("SelCate")]
        [HttpGet]
        public IHttpActionResult SelectCategory()
        {
            CTNEntities1 db = new CTNEntities1();

            var list = db.Category
                    .Select(c => new
                    {
                        c.CaID,
                        c.CaName,
                        c.CaQName,
                        c.CaIcon,
                        c.CaOrder
                    });

            return Ok(list);

        }
        #endregion

        #region 工作机会
        [Route("Seljob/{id}")]
        [HttpGet]
        public IHttpActionResult Selectjob(int id)
        {
            int index = 1;
            int size = 5;
            int count = 0;
            dynamic data=null;
            if (id==1)
            {
                CTNEntities1 db = new CTNEntities1();
                {
                     count = db.Job.Count();
                    data  = db.Job.OrderByDescending(o=>o.JID).Skip((index - 1) * size).Take(size)
                        .Select(j => new
                     {
                         j.JID,
                         Caid=j.Caid,
                         Coid=j.Coid,
                         j.ftime,
                         j.Jdepict,
                         j.JName,
                         j.JNrank,
                         j.Jquality,
                         j.Jrank,
                         j.Jsalary,
                         j.Jzdsaldw,
                         j.Jzdsaldy,
                         j.Jzgsaldy,
                         j.Place,
                         j.Ptime
                     }).ToList();
                }
                int PageAll = count % size == 0 ? count / size : count / size + 1;

                return Json(new { index = index, count = count, PageAll = PageAll, data = data });
            }
            else
            {
                CTNEntities1 db = new CTNEntities1();
                {
                    count = db.Job.Count();
                    data = db.Job.OrderBy(o => o.JID).Skip((index - 1) * size).Take(size)
                        .Select(j => new
                        {
                            j.JID,
                            Caid = j.Caid,
                            Coid = j.Coid,
                            j.ftime,
                            j.Jdepict,
                            j.JName,
                            j.JNrank,
                            j.Jquality,
                            j.Jrank,
                            j.Jsalary,
                            j.Jzdsaldw,
                            j.Jzdsaldy,
                            j.Jzgsaldy,
                            j.Place,
                            j.Ptime
                        }).ToList();
                }
                int PageAll = count % size == 0 ? count / size : count / size + 1;

                return Json(new { index = index, count = count, PageAll = PageAll, data = data });
            }
        #endregion
        }
    }
}
