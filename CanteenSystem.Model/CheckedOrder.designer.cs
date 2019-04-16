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
	public partial class CheckedOrderDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertCheckedOrder(CheckedOrder instance);
    partial void UpdateCheckedOrder(CheckedOrder instance);
    partial void DeleteCheckedOrder(CheckedOrder instance);
    #endregion
		
		public CheckedOrderDataContext() : 
				base(global::CanteenSystem.Model.Properties.Settings.Default.CanteenDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CheckedOrderDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CheckedOrderDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CheckedOrderDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CheckedOrderDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CheckedOrder> CheckedOrder
		{
			get
			{
				return this.GetTable<CheckedOrder>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CheckedOrder")]
	public partial class CheckedOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CheckedOrderID;
		
		private string _OrderNumber;
		
		private string _Department;
		
		private string _Creator;
		
		private System.Nullable<System.DateTime> _InputDate;
		
		private System.Nullable<double> _TotalMoney;
		
		private string _Status;
		
		private string _Verifier;
		
		private System.Nullable<System.DateTime> _VeriDate;
		
		private string _Provider;
		
		private string _Remark;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCheckedOrderIDChanging(string value);
    partial void OnCheckedOrderIDChanged();
    partial void OnOrderNumberChanging(string value);
    partial void OnOrderNumberChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnCreatorChanging(string value);
    partial void OnCreatorChanged();
    partial void OnInputDateChanging(System.Nullable<System.DateTime> value);
    partial void OnInputDateChanged();
    partial void OnTotalMoneyChanging(System.Nullable<double> value);
    partial void OnTotalMoneyChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnVerifierChanging(string value);
    partial void OnVerifierChanged();
    partial void OnVeriDateChanging(System.Nullable<System.DateTime> value);
    partial void OnVeriDateChanged();
    partial void OnProviderChanging(string value);
    partial void OnProviderChanged();
    partial void OnRemarkChanging(string value);
    partial void OnRemarkChanged();
    #endregion
		
		public CheckedOrder()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckedOrderID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CheckedOrderID
		{
			get
			{
				return this._CheckedOrderID;
			}
			set
			{
				if ((this._CheckedOrderID != value))
				{
					this.OnCheckedOrderIDChanging(value);
					this.SendPropertyChanging();
					this._CheckedOrderID = value;
					this.SendPropertyChanged("CheckedOrderID");
					this.OnCheckedOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", DbType="VarChar(50)")]
		public string OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
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
					this.OnCreatorChanging(value);
					this.SendPropertyChanging();
					this._Creator = value;
					this.SendPropertyChanged("Creator");
					this.OnCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InputDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> InputDate
		{
			get
			{
				return this._InputDate;
			}
			set
			{
				if ((this._InputDate != value))
				{
					this.OnInputDateChanging(value);
					this.SendPropertyChanging();
					this._InputDate = value;
					this.SendPropertyChanged("InputDate");
					this.OnInputDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalMoney", DbType="Float")]
		public System.Nullable<double> TotalMoney
		{
			get
			{
				return this._TotalMoney;
			}
			set
			{
				if ((this._TotalMoney != value))
				{
					this.OnTotalMoneyChanging(value);
					this.SendPropertyChanging();
					this._TotalMoney = value;
					this.SendPropertyChanged("TotalMoney");
					this.OnTotalMoneyChanged();
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
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
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
					this.OnVerifierChanging(value);
					this.SendPropertyChanging();
					this._Verifier = value;
					this.SendPropertyChanged("Verifier");
					this.OnVerifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VeriDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> VeriDate
		{
			get
			{
				return this._VeriDate;
			}
			set
			{
				if ((this._VeriDate != value))
				{
					this.OnVeriDateChanging(value);
					this.SendPropertyChanging();
					this._VeriDate = value;
					this.SendPropertyChanged("VeriDate");
					this.OnVeriDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provider", DbType="VarChar(50)")]
		public string Provider
		{
			get
			{
				return this._Provider;
			}
			set
			{
				if ((this._Provider != value))
				{
					this.OnProviderChanging(value);
					this.SendPropertyChanging();
					this._Provider = value;
					this.SendPropertyChanged("Provider");
					this.OnProviderChanged();
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
					this.OnRemarkChanging(value);
					this.SendPropertyChanging();
					this._Remark = value;
					this.SendPropertyChanged("Remark");
					this.OnRemarkChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
