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
	public partial class view_PlanDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public view_PlanDataContext() : 
				base(global::CanteenSystem.Model.Properties.Settings.Default.CanteenDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public view_PlanDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public view_PlanDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public view_PlanDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public view_PlanDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<view_Plan> view_Plan
		{
			get
			{
				return this.GetTable<view_Plan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.view_Plan")]
	public partial class view_Plan
	{
		
		private string _PlanID;
		
		private string _MenuName;
		
		private string _Unit;
		
		private System.Nullable<double> _Count;
		
		private System.Nullable<double> _Price;
		
		private string _Remark;
		
		private string _ParentName;
		
		public view_Plan()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PlanID
		{
			get
			{
				return this._PlanID;
			}
			set
			{
				if ((this._PlanID != value))
				{
					this._PlanID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuName", DbType="VarChar(50)")]
		public string MenuName
		{
			get
			{
				return this._MenuName;
			}
			set
			{
				if ((this._MenuName != value))
				{
					this._MenuName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="VarChar(50)")]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this._Unit = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Count", DbType="Float")]
		public System.Nullable<double> Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				if ((this._Count != value))
				{
					this._Count = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentName", DbType="VarChar(50)")]
		public string ParentName
		{
			get
			{
				return this._ParentName;
			}
			set
			{
				if ((this._ParentName != value))
				{
					this._ParentName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591