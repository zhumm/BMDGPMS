
///=========================================================================
/// 版    权： Coypright 2012 - 2016 @ zhumingming(Berton)
/// 文件名称： UserMenu.cs
/// 模版作者： zhumingming(berton) 最后修改于 2016-5-27 16:10:10
/// 作者邮箱： zhumingming1040@163.com,937553351@qq.com
/// 描    述： 表[UserMenu]的 Entity 层代码
/// 创 建 人： zhumingming(Berton) (CodeSmith V6.5.0 自动生成的代码 模板V4.0)
/// 创建时间： 2016/6/2 11:14:34
///=========================================================================

using System;
using System.Text;
using MDORM.DapperExt.Mapper;

namespace MDORM.Entity
{
    /// <summary>
 	/// UserMenu 实体类,包括:属性，重写的ToString方法
 	/// </summary>
    /// 创建人：zhumingming(Berton)
    /// 创建时间：2016/6/2 11:14:34
	[Serializable]
	public class UserMenu
	{
        #region 成员变量
        private Guid? _iD;
        private Guid? _userId;
        private Guid? _menuId;
        private bool? _enable;
        private string _creater;
        private DateTime? _createTime;
        private string _modifier;
        private DateTime? _modifyTime;
        #endregion
		
        #region 属性
        /// <summary>
        /// ID
        /// </summary>
		public Guid? ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}
        
        /// <summary>
        /// UserId
        /// </summary>
		public Guid? UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}
        
        /// <summary>
        /// MenuId
        /// </summary>
		public Guid? MenuId
		{
			get { return this._menuId; }
			set { this._menuId = value; }
		}
        
        /// <summary>
        /// 是否启用
        /// </summary>
		public bool? Enable
		{
			get { return this._enable; }
			set { this._enable = value; }
		}
        
        /// <summary>
        /// 创建人
        /// </summary>
		public string Creater
		{
			get { return this._creater; }
			set { this._creater = value; }
		}
        
        /// <summary>
        /// 创建时间
        /// </summary>
		public DateTime? CreateTime
		{
			get { return this._createTime; }
			set { this._createTime = value; }
		}
        
        /// <summary>
        /// 修改人
        /// </summary>
		public string Modifier
		{
			get { return this._modifier; }
			set { this._modifier = value; }
		}
        
        /// <summary>
        /// 修改时间
        /// </summary>
		public DateTime? ModifyTime
		{
			get { return this._modifyTime; }
			set { this._modifyTime = value; }
		}
        
        #endregion
        
        #region 扩展的变量、属性、方法
        /// <summary>
        /// 返回这个对象的JSON格式字符串，方便记录日志
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            temp.Append("[{ ");
		    temp.AppendFormat("\"ID\":\"{0}\", ",this.ID);
		    temp.AppendFormat("\"UserId\":\"{0}\", ",this.UserId);
		    temp.AppendFormat("\"MenuId\":\"{0}\", ",this.MenuId);
		    temp.AppendFormat("\"Enable\":\"{0}\", ",this.Enable);
		    temp.AppendFormat("\"Creater\":\"{0}\", ",this.Creater);
		    temp.AppendFormat("\"CreateTime\":\"{0}\", ",this.CreateTime);
		    temp.AppendFormat("\"Modifier\":\"{0}\", ",this.Modifier);
		    temp.AppendFormat("\"ModifyTime\":\"{0}\", ",this.ModifyTime);
            int lastPos = temp.ToString().LastIndexOf(',');
            if (lastPos != -1)
                temp = temp.Remove(lastPos, 1);
            temp.Append("}]");
            return temp.ToString();
        }
        #endregion
	}
    
    /// <summary>
    /// UserMenu 映射类
    /// </summary>
    /// 创建人：朱明明
    /// 创建时间：2016/5/23 15:03:02

    [Serializable]
    public class UserMenuMapper : ClassMapper<UserMenu>
    {
        /// <summary>
 	    /// UserMenu Mapper构造函数（可自定义Mapper）
 	    /// </summary>
        public UserMenuMapper()
        {
            base.Table("UserMenu");
            Map(f => f.ID).Key(KeyType.Guid);           
            AutoMap();
        }
    }
}
