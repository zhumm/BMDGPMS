using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MDORM.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class WebHelper
    {
        /// <summary>
        /// 获取参数内容
        /// </summary>
        /// <param name="request">HTTP请求对象</param>
        /// <param name="key">键</param>
        /// <returns>对应的值</returns>
        public static string GetParam(HttpRequestBase request, string key)
        {
            switch (request.HttpMethod)
            {
                case "GET":
                    return GetQueryString(request, key);
                case "POST":
                    return GetForm(request, key);
                default:
                    return GetParamBase(request, key);
            }
        }

        /// <summary>
        /// 获取Get类型参数
        /// </summary>
        /// <param name="request"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetQueryString(HttpRequestBase request, string key)
        {
            if (request.QueryString.AllKeys.Contains(key))
            {
                string temp = request.QueryString[key];
                if (!string.IsNullOrEmpty(temp))
                {
                    temp = temp.Trim();
                }
                return temp;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取POST类型参数
        /// </summary>
        /// <param name="request"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetForm(HttpRequestBase request, string key)
        {
            if (request.Form.AllKeys.Contains(key))
            {
                string temp = request.Form[key];
                if (!string.IsNullOrEmpty(temp))
                {
                    temp = temp.Trim();
                }
                return temp;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取所有参数
        /// </summary>
        /// <param name="request"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetParamBase(HttpRequestBase request, string key)
        {
            if (request.Params.AllKeys.Contains(key))
            {
                string temp = request.Params[key];
                if (!string.IsNullOrEmpty(temp))
                {
                    temp = temp.Trim();
                }
                return temp;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
