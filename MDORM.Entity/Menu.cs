﻿
///=========================================================================
/// 版    权： Coypright 2012 - 2016 @ zhumingming(Berton)
/// 文件名称： Menu.cs
/// 模版作者： zhumingming(berton) 最后修改于 2016-5-27 16:10:10
/// 作者邮箱： zhumingming1040@163.com,937553351@qq.com
/// 描    述： 表[Menu]的 Entity 层代码
/// 创 建 人： zhumingming(Berton) (CodeSmith V6.5.0 自动生成的代码 模板V4.0)
/// 创建时间： 2016/6/2 11:14:33
///=========================================================================

using System;
using System.Text;
using MDORM.DapperExt.Mapper;

namespace MDORM.Entity
{
    /// <summary>
 	/// Menu 实体类,包括:属性，重写的ToString方法
 	/// </summary>
    /// 创建人：zhumingming(Berton)
    /// 创建时间：2016/6/2 11:14:33
	[Serializable]
	public class Menu
	{
        #region 成员变量
        private Guid? _iD;
        private int? _menuOrder;
        private string _chineseName;
        private string _englishName;
        private string _resURL;
        private int? _type;
        private bool? _enable;
        private string _creater;
        private DateTime? _createTime;
        private string _modifier;
        private DateTime? _modifyTime;
        private string _remark;
        private Guid? _parentId;
        private string _iCON;
        #endregion
		
        #region 属性
        /// <summary>
        /// 主键
        /// </summary>
		public Guid? ID
		{
			get { return this._iD; }
			set { this._iD = value; }
		}
        
        /// <summary>
        /// 排序
        /// </summary>
		public int? MenuOrder
		{
			get { return this._menuOrder; }
			set { this._menuOrder = value; }
		}
        
        /// <summary>
        /// 中文名称
        /// </summary>
		public string ChineseName
		{
			get { return this._chineseName; }
			set { this._chineseName = value; }
		}
        
        /// <summary>
        /// 英文名称
        /// </summary>
		public string EnglishName
		{
			get { return this._englishName; }
			set { this._englishName = value; }
		}
        
        /// <summary>
        /// 资源地址
        /// </summary>
		public string ResURL
		{
			get { return this._resURL; }
			set { this._resURL = value; }
		}
        
        /// <summary>
        /// 类型
        /// </summary>
		public int? Type
		{
			get { return this._type; }
			set { this._type = value; }
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
        
        /// <summary>
        /// 信息备注
        /// </summary>
		public string Remark
		{
			get { return this._remark; }
			set { this._remark = value; }
		}
        
        /// <summary>
        /// 父级ID
        /// </summary>
		public Guid? ParentId
		{
			get { return this._parentId; }
			set { this._parentId = value; }
		}
        
        /// <summary>
        /// 图标
        /// </summary>
		public string ICON
		{
			get { return this._iCON; }
			set { this._iCON = value; }
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
		    temp.AppendFormat("\"MenuOrder\":\"{0}\", ",this.MenuOrder);
		    temp.AppendFormat("\"ChineseName\":\"{0}\", ",this.ChineseName);
		    temp.AppendFormat("\"EnglishName\":\"{0}\", ",this.EnglishName);
		    temp.AppendFormat("\"ResURL\":\"{0}\", ",this.ResURL);
		    temp.AppendFormat("\"Type\":\"{0}\", ",this.Type);
		    temp.AppendFormat("\"Enable\":\"{0}\", ",this.Enable);
		    temp.AppendFormat("\"Creater\":\"{0}\", ",this.Creater);
		    temp.AppendFormat("\"CreateTime\":\"{0}\", ",this.CreateTime);
		    temp.AppendFormat("\"Modifier\":\"{0}\", ",this.Modifier);
		    temp.AppendFormat("\"ModifyTime\":\"{0}\", ",this.ModifyTime);
		    temp.AppendFormat("\"Remark\":\"{0}\", ",this.Remark);
		    temp.AppendFormat("\"ParentId\":\"{0}\", ",this.ParentId);
		    temp.AppendFormat("\"ICON\":\"{0}\", ",this.ICON);
            int lastPos = temp.ToString().LastIndexOf(',');
            if (lastPos != -1)
                temp = temp.Remove(lastPos, 1);
            temp.Append("}]");
            return temp.ToString();
        }
        #endregion
	}
    
    /// <summary>
    /// Menu 映射类
    /// </summary>
    /// 创建人：朱明明
    /// 创建时间：2016/5/23 15:03:02

    [Serializable]
    public class MenuMapper : ClassMapper<Menu>
    {
        /// <summary>
 	    /// Menu Mapper构造函数（可自定义Mapper）
 	    /// </summary>
        public MenuMapper()
        {
            base.Table("Menu");
            Map(f => f.ID).Key(KeyType.Guid);           
            AutoMap();
        }
    }
}
