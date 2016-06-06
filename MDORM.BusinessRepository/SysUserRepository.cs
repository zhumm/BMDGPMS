
///=========================================================================
/// 版    权： Coypright 2012 - 2016 @ zhumingming(Berton)
/// 文件名称： SysUserRepository.cs
/// 模版作者： zhumingming(berton) 最后修改于 2016-5-27 16:10:10
/// 作者邮箱： zhumingming1040@163.com,937553351@qq.com
/// 描    述： 表[SysUser]的 BusinessReposity 层代码
/// 创 建 人： zhumingming(Berton) (CodeSmith V6.5.0 自动生成的代码 模板V4.0)
/// 创建时间： 2016/6/2 11:14:34
///=========================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using MDORM.Entity;
using MDORM.DBUtility;
using MDORM.DapperExt;

namespace MDORM.BusinessRepository
{
    /// <summary>
    /// 表[SysUser] 数据仓库代码
    /// </summary>
    /// 创建人：zhumingming(Berton)
    /// 创建时间：2016/6/2 11:14:34
	public partial class SysUserRepository : RepositoryBase<SysUser>
	{
        #region 静态SysUserRepository对象,单例模式。 
		private static SysUserRepository _value;
        
        /// <summary>
        /// 静态SysUserRepository对象,单例模式。
        /// </summary>
        public static SysUserRepository Value
        {
            get
            {
                if (SysUserRepository._value == null)
                    SysUserRepository._value = new SysUserRepository();
                return SysUserRepository._value;
            }
        }
        #endregion 
        
        #region 构造函数
        /// <summary>
        /// Initializes a new instance of the <see cref="SysUserRepository"/> class.
        /// </summary>
        public SysUserRepository()
        {
            SysUserRepository._value = this;
        }
        #endregion
        
        #region 成员方法
        /// <summary>
        /// 分页获取,默认按照时间降序排序
        /// </summary>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="allRowsCount">全部记录数</param>
        /// <param name="predicate">查询条件</param>
        /// <param name="sort">排序</param>
        /// <returns></returns>
        public List<SysUser> GetPage(int pageIndex, int pageSize, out int allRowsCount, object predicate = null, IList<ISort> sort = null)
        {
            if (sort == null || sort.Count <= 0)
            {
                sort = new List<ISort>();
                sort.Add(Predicates.Sort<SysUser>(p => p.CreateTime, true));
            }
            return base.GetPage(pageIndex, pageSize, out allRowsCount, predicate, sort);
        }
        #endregion
        
        #region 扩展的方法
        #endregion
	}
}
