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
	public partial class View_OrderDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public View_OrderDataContext() : 
				base(global::CanteenSystem.Model.Properties.Settings.Default.CanteenDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public View_OrderDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_OrderDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_OrderDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public View_OrderDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_Order> View_Order
		{
			get
			{
				return this.GetTable<View_Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Order")]
	public partial class View_Order
	{
		
		private string _OrderID;
		
		private string _OrderName;
		
		private string _Group;
		
		private string _MenuName;
		
		private string _Unit;
		
		private System.Nullable<double> _RealCount;
		
		private System.Nullable<double> _Price;
		
		private string _Creator;
		
		private System.Nullable<System.DateTime> _CreateTime;
		
		private string _Verifier;
		
		private string _Status;
		
		private string _ProviderName;
		
		public View_Order()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this._OrderID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderName", DbType="VarChar(50)")]
		public string OrderName
		{
			get
			{
				return this._OrderName;
			}
			set
			{
				if ((this._OrderName != value))
				{
					this._OrderName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Group]", Storage="_Group", DbType="VarChar(50)")]
		public string Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				if ((this._Group != value))
				{
					this._Group = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RealCount", DbType="Float")]
		public System.Nullable<double> RealCount
		{
			get
			{
				return this._RealCount;
			}
			set
			{
				if ((this._RealCount != value))
				{
					this._RealCount = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creator", DbType="VarChar(50)")]
		public string Creator
		{
			get
			{
				return this._Creator;
			}
			set
			{
				if ((this._Creator != value))
				{
					this._Creator = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this._CreateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Verifier", DbType="VarChar(50)")]
		public string Verifier
		{
			get
			{
				return this._Verifier;
			}
			set
			{
				if ((this._Verifier != value))
				{
					this._Verifier = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this._Status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProviderName", DbType="VarChar(100)")]
		public string ProviderName
		{
			get
			{
				return this._ProviderName;
			}
			set
			{
				if ((this._ProviderName != value))
				{
					this._ProviderName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
