﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CanteenSystem.Model
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CanteenDB")]
	public partial class View_GroupDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public View_GroupDataContext() : 
				base(global::CanteenSystem.Model.Properties.Settings.Default.CanteenDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public View_GroupDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_GroupDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_GroupDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_GroupDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_Group> View_Group
		{
			get
			{
				return this.GetTable<View_Group>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Group")]
	public partial class View_Group
	{
		
		private string _UsersGroup_ID;
		
		private string _GroupID;
		
		private string _UserID;
		
		private string _UserName;
		
		private string _RealName;
		
		private string _GroupName;
		
		private string _Remark;
		
		public View_Group()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsersGroup_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UsersGroup_ID
		{
			get
			{
				return this._UsersGroup_ID;
			}
			set
			{
				if ((this._UsersGroup_ID != value))
				{
					this._UsersGroup_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupID", DbType="VarChar(50)")]
		public string GroupID
		{
			get
			{
				return this._GroupID;
			}
			set
			{
				if ((this._GroupID != value))
				{
					this._GroupID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(50)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RealName", DbType="VarChar(50)")]
		public string RealName
		{
			get
			{
				return this._RealName;
			}
			set
			{
				if ((this._RealName != value))
				{
					this._RealName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupName", DbType="VarChar(50)")]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this._GroupName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remark", DbType="VarChar(200)")]
		public string Remark
		{
			get
			{
				return this._Remark;
			}
			set
			{
				if ((this._Remark != value))
				{
					this._Remark = value;
				}
			}
		}
	}
}
#pragma warning restore 1591