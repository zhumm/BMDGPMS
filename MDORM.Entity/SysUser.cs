
///=========================================================================
/// 版    权： Coypright 2012 - 2016 @ zhumingming(Berton)
/// 文件名称： SysUser.cs
/// 模版作者： zhumingming(berton) 最后修改于 2016-5-27 16:10:10
/// 作者邮箱： zhumingming1040@163.com,937553351@qq.com
/// 描    述： 表[SysUser]的 Entity 层代码
/// 创 建 人： zhumingming(Berton) (CodeSmith V6.5.0 自动生成的代码 模板V4.0)
/// 创建时间： 2016/6/2 11:14:33
///=========================================================================

using System;
using System.Text;
using MDORM.DapperExt.Mapper;

namespace MDORM.Entity
{
    /// <summary>
 	/// SysUser 实体类,包括:属性，重写的ToString方法
 	/// </summary>
    /// 创建人：zhumingming(Berton)
    /// 创建时间：2016/6/2 11:14:33
	[Serializable]
	public class SysUser
	{
        #region 成员变量
        private Guid? _iD;
        private string _userName;
        private string _trueName;
        private int? _userType;
        private int? _sex;
        private DateTime? _birthDay;
        private string _password;
        private string _loginIP;
        private DateTime? _loginTime;
        private string _lastLoginIP;
        private DateTime? _lastLoginTime;
        private bool? _enable;
        private string _remark;
        private string _creater;
        private DateTime? _createTime;
        private string _modifier;
        private DateTime? _modifyTime;
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
        /// 用户名称
        /// </summary>
		public string UserName
		{
			get { return this._userName; }
			set { this._userName = value; }
		}
        
        /// <summary>
        /// 真是姓名
        /// </summary>
		public string TrueName
		{
			get { return this._trueName; }
			set { this._trueName = value; }
		}
        
        /// <summary>
        /// UserType
        /// </summary>
		public int? UserType
		{
			get { return this._userType; }
			set { this._userType = value; }
		}
        
        /// <summary>
        /// 性别
        /// </summary>
		public int? Sex
		{
			get { return this._sex; }
			set { this._sex = value; }
		}
        
        /// <summary>
        /// 出生日期
        /// </summary>
		public DateTime? BirthDay
		{
			get { return this._birthDay; }
			set { this._birthDay = value; }
		}
        
        /// <summary>
        /// 密码
        /// </summary>
		public string Password
		{
			get { return this._password; }
			set { this._password = value; }
		}
        
        /// <summary>
        /// 本次登录IP
        /// </summary>
		public string LoginIP
		{
			get { return this._loginIP; }
			set { this._loginIP = value; }
		}
        
        /// <summary>
        /// 本次登录时间
        /// </summary>
		public DateTime? LoginTime
		{
			get { return this._loginTime; }
			set { this._loginTime = value; }
		}
        
        /// <summary>
        /// 最后登录IP
        /// </summary>
		public string LastLoginIP
		{
			get { return this._lastLoginIP; }
			set { this._lastLoginIP = value; }
		}
        
        /// <summary>
        /// 最后登录时间
        /// </summary>
		public DateTime? LastLoginTime
		{
			get { return this._lastLoginTime; }
			set { this._lastLoginTime = value; }
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
        /// 信息备注
        /// </summary>
		public string Remark
		{
			get { return this._remark; }
			set { this._remark = value; }
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
		    temp.AppendFormat("\"UserName\":\"{0}\", ",this.UserName);
		    temp.AppendFormat("\"TrueName\":\"{0}\", ",this.TrueName);
		    temp.AppendFormat("\"UserType\":\"{0}\", ",this.UserType);
		    temp.AppendFormat("\"Sex\":\"{0}\", ",this.Sex);
		    temp.AppendFormat("\"BirthDay\":\"{0}\", ",this.BirthDay);
		    temp.AppendFormat("\"Password\":\"{0}\", ",this.Password);
		    temp.AppendFormat("\"LoginIP\":\"{0}\", ",this.LoginIP);
		    temp.AppendFormat("\"LoginTime\":\"{0}\", ",this.LoginTime);
		    temp.AppendFormat("\"LastLoginIP\":\"{0}\", ",this.LastLoginIP);
		    temp.AppendFormat("\"LastLoginTime\":\"{0}\", ",this.LastLoginTime);
		    temp.AppendFormat("\"Enable\":\"{0}\", ",this.Enable);
		    temp.AppendFormat("\"Remark\":\"{0}\", ",this.Remark);
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
    /// SysUser 映射类
    /// </summary>
    /// 创建人：朱明明
    /// 创建时间：2016/5/23 15:03:02

    [Serializable]
    public class SysUserMapper : ClassMapper<SysUser>
    {
        /// <summary>
 	    /// SysUser Mapper构造函数（可自定义Mapper）
 	    /// </summary>
        public SysUserMapper()
        {
            base.Table("SysUser");
            Map(f => f.ID).Key(KeyType.Guid);           
            AutoMap();
        }
    }
}
