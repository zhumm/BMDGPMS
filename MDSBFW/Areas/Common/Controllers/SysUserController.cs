using MDORM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MDORM.BusinessRepository;
using MDORM.DBUtility;
using MDORM.Entity;
using MDSBFW.CommonHelper;

namespace MDSBFW.Areas.Common.Controllers
{
    public class SysUserController : Controller
    {
        //
        // GET: /Common/SysUser/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Search()
        {
            string pageIndex = WebHelper.GetParam(Request, "page");
            string pageSize = WebHelper.GetParam(Request, "rows");
            int PageIndex = string.IsNullOrEmpty(pageIndex) ? 1 : Convert.ToInt32(pageIndex);
            int PageSize = string.IsNullOrEmpty(pageSize) ? 10 : Convert.ToInt32(pageSize);
            int totalCount = 0;
            var result = SysUserRepository.Value.GetPage(PageIndex - 1, PageSize, out totalCount);
            var jso = new
            {
                total = totalCount,
                rows = result
            };
            return CommonHelper.CommonOperate.ToJson(jso);
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Add(SysUser user)
        {
            user.ID = Guid.NewGuid();
            user.Creater = "admin";
            user.CreateTime = DateTime.Now;
            user.Password = Encrypt.MD5Encrypt(user.Password);
            Guid newID = SysUserRepository.Value.Insert(user);
            if (newID != Guid.Empty)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public string GetById(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                return "false";
            }
            SysUser user = SysUserRepository.Value.GetById(Id);

            return CommonOperate.ToJson(user);

        }
    }
}
