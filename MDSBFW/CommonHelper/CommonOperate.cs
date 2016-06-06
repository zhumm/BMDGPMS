using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MDSBFW.CommonHelper
{
    /// <summary>
    /// 通用操作
    /// </summary>
    public class CommonOperate
    {
        /// <summary>
        /// 把对象为json字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(object obj)
        {
            string jsonData = (new JavaScriptSerializer()).Serialize(obj);
            return jsonData;
        }
    }
}