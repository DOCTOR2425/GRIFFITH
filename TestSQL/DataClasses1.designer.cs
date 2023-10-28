﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Notary")]
	public partial class TestDataBase : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertDiscount(Discount instance);
    partial void UpdateDiscount(Discount instance);
    partial void DeleteDiscount(Discount instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertService(Service instance);
    partial void UpdateService(Service instance);
    partial void DeleteService(Service instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public TestDataBase() : 
				base(global::TestSQL.Properties.Settings.Default.NotaryConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataBase(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataBase(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataBase(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataBase(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Client> Client
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<Discount> Discount
		{
			get
			{
				return this.GetTable<Discount>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employee
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Service> Service
		{
			get
			{
				return this.GetTable<Service>();
			}
		}
		
		public System.Data.Linq.Table<Order> Order
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ClientID;
		
		private string _Name;
		
		private string _Telephone;
		
		private string _Activity;
		
		private EntityRef<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClientIDChanging(System.Guid value);
    partial void OnClientIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTelephoneChanging(string value);
    partial void OnTelephoneChanged();
    partial void OnActivityChanging(string value);
    partial void OnActivityChanged();
    #endregion
		
		public Client()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClientIDChanging(value);
					this.SendPropertyChanging();
					this._ClientID = value;
					this.SendPropertyChanged("ClientID");
					this.OnClientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this.OnTelephoneChanging(value);
					this.SendPropertyChanging();
					this._Telephone = value;
					this.SendPropertyChanged("Telephone");
					this.OnTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activity", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Activity
		{
			get
			{
				return this._Activity;
			}
			set
			{
				if ((this._Activity != value))
				{
					this.OnActivityChanging(value);
					this.SendPropertyChanging();
					this._Activity = value;
					this.SendPropertyChanged("Activity");
					this.OnActivityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Client", Storage="_Order", ThisKey="ClientID", OtherKey="ClientID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Client.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Client.Add(this);
						this._ClientID = value.ClientID;
					}
					else
					{
						this._ClientID = default(System.Guid);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Discount")]
	public partial class Discount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _DiscountID;
		
		private string _Name;
		
		private double _Percent;
		
		private string _Description;
		
		private int _NewFlag;
		
		private EntityRef<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDiscountIDChanging(System.Guid value);
    partial void OnDiscountIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPercentChanging(double value);
    partial void OnPercentChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNewFlagChanging(int value);
    partial void OnNewFlagChanged();
    #endregion
		
		public Discount()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscountID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid DiscountID
		{
			get
			{
				return this._DiscountID;
			}
			set
			{
				if ((this._DiscountID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDiscountIDChanging(value);
					this.SendPropertyChanging();
					this._DiscountID = value;
					this.SendPropertyChanged("DiscountID");
					this.OnDiscountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Percent]", Storage="_Percent", DbType="Float NOT NULL")]
		public double Percent
		{
			get
			{
				return this._Percent;
			}
			set
			{
				if ((this._Percent != value))
				{
					this.OnPercentChanging(value);
					this.SendPropertyChanging();
					this._Percent = value;
					this.SendPropertyChanged("Percent");
					this.OnPercentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewFlag", DbType="Int NOT NULL")]
		public int NewFlag
		{
			get
			{
				return this._NewFlag;
			}
			set
			{
				if ((this._NewFlag != value))
				{
					this.OnNewFlagChanging(value);
					this.SendPropertyChanging();
					this._NewFlag = value;
					this.SendPropertyChanged("NewFlag");
					this.OnNewFlagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Discount", Storage="_Order", ThisKey="DiscountID", OtherKey="DiscountID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Discount.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Discount.Add(this);
						this._DiscountID = value.DiscountID;
					}
					else
					{
						this._DiscountID = default(System.Guid);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _EmployeeID;
		
		private string _Name;
		
		private double _Salary;
		
		private System.DateTime _HireDate;
		
		private string _Post;
		
		private System.Nullable<System.DateTime> _DismissalDate;
		
		private EntityRef<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(System.Guid value);
    partial void OnEmployeeIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSalaryChanging(double value);
    partial void OnSalaryChanged();
    partial void OnHireDateChanging(System.DateTime value);
    partial void OnHireDateChanged();
    partial void OnPostChanging(string value);
    partial void OnPostChanged();
    partial void OnDismissalDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDismissalDateChanged();
    #endregion
		
		public Employee()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Float NOT NULL")]
		public double Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HireDate", DbType="Date NOT NULL")]
		public System.DateTime HireDate
		{
			get
			{
				return this._HireDate;
			}
			set
			{
				if ((this._HireDate != value))
				{
					this.OnHireDateChanging(value);
					this.SendPropertyChanging();
					this._HireDate = value;
					this.SendPropertyChanged("HireDate");
					this.OnHireDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Post
		{
			get
			{
				return this._Post;
			}
			set
			{
				if ((this._Post != value))
				{
					this.OnPostChanging(value);
					this.SendPropertyChanging();
					this._Post = value;
					this.SendPropertyChanged("Post");
					this.OnPostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DismissalDate", DbType="Date")]
		public System.Nullable<System.DateTime> DismissalDate
		{
			get
			{
				return this._DismissalDate;
			}
			set
			{
				if ((this._DismissalDate != value))
				{
					this.OnDismissalDateChanging(value);
					this.SendPropertyChanging();
					this._DismissalDate = value;
					this.SendPropertyChanged("DismissalDate");
					this.OnDismissalDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Employee", Storage="_Order", ThisKey="EmployeeID", OtherKey="EmployeeID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Employee.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Employee.Add(this);
						this._EmployeeID = value.EmployeeID;
					}
					else
					{
						this._EmployeeID = default(System.Guid);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Service")]
	public partial class Service : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ServiceID;
		
		private string _Name;
		
		private double _Price;
		
		private string _Description;
		
		private int _NewFlag;
		
		private EntityRef<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnServiceIDChanging(System.Guid value);
    partial void OnServiceIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNewFlagChanging(int value);
    partial void OnNewFlagChanged();
    #endregion
		
		public Service()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ServiceID
		{
			get
			{
				return this._ServiceID;
			}
			set
			{
				if ((this._ServiceID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnServiceIDChanging(value);
					this.SendPropertyChanging();
					this._ServiceID = value;
					this.SendPropertyChanged("ServiceID");
					this.OnServiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewFlag", DbType="Int NOT NULL")]
		public int NewFlag
		{
			get
			{
				return this._NewFlag;
			}
			set
			{
				if ((this._NewFlag != value))
				{
					this.OnNewFlagChanging(value);
					this.SendPropertyChanging();
					this._NewFlag = value;
					this.SendPropertyChanged("NewFlag");
					this.OnNewFlagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Service", Storage="_Order", ThisKey="ServiceID", OtherKey="ServiceID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Service.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Service.Add(this);
						this._ServiceID = value.ServiceID;
					}
					else
					{
						this._ServiceID = default(System.Guid);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _OrderID;
		
		private System.Guid _ClientID;
		
		private System.Guid _ServiceID;
		
		private System.Guid _DiscountID;
		
		private System.Guid _EmployeeID;
		
		private System.DateTime _Date;
		
		private EntitySet<Service> _Service;
		
		private EntitySet<Client> _Client;
		
		private EntitySet<Employee> _Employee;
		
		private EntitySet<Discount> _Discount;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(System.Guid value);
    partial void OnOrderIDChanged();
    partial void OnClientIDChanging(System.Guid value);
    partial void OnClientIDChanged();
    partial void OnServiceIDChanging(System.Guid value);
    partial void OnServiceIDChanged();
    partial void OnDiscountIDChanging(System.Guid value);
    partial void OnDiscountIDChanged();
    partial void OnEmployeeIDChanging(System.Guid value);
    partial void OnEmployeeIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Order()
		{
			this._Service = new EntitySet<Service>(new Action<Service>(this.attach_Service), new Action<Service>(this.detach_Service));
			this._Client = new EntitySet<Client>(new Action<Client>(this.attach_Client), new Action<Client>(this.detach_Client));
			this._Employee = new EntitySet<Employee>(new Action<Employee>(this.attach_Employee), new Action<Employee>(this.detach_Employee));
			this._Discount = new EntitySet<Discount>(new Action<Discount>(this.attach_Discount), new Action<Discount>(this.detach_Discount));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				if ((this._ClientID != value))
				{
					this.OnClientIDChanging(value);
					this.SendPropertyChanging();
					this._ClientID = value;
					this.SendPropertyChanged("ClientID");
					this.OnClientIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ServiceID
		{
			get
			{
				return this._ServiceID;
			}
			set
			{
				if ((this._ServiceID != value))
				{
					this.OnServiceIDChanging(value);
					this.SendPropertyChanging();
					this._ServiceID = value;
					this.SendPropertyChanged("ServiceID");
					this.OnServiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscountID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid DiscountID
		{
			get
			{
				return this._DiscountID;
			}
			set
			{
				if ((this._DiscountID != value))
				{
					this.OnDiscountIDChanging(value);
					this.SendPropertyChanging();
					this._DiscountID = value;
					this.SendPropertyChanged("DiscountID");
					this.OnDiscountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Service", Storage="_Service", ThisKey="ServiceID", OtherKey="ServiceID")]
		public EntitySet<Service> Service
		{
			get
			{
				return this._Service;
			}
			set
			{
				this._Service.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Client", Storage="_Client", ThisKey="ClientID", OtherKey="ClientID")]
		public EntitySet<Client> Client
		{
			get
			{
				return this._Client;
			}
			set
			{
				this._Client.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Employee", Storage="_Employee", ThisKey="EmployeeID", OtherKey="EmployeeID")]
		public EntitySet<Employee> Employee
		{
			get
			{
				return this._Employee;
			}
			set
			{
				this._Employee.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Discount", Storage="_Discount", ThisKey="DiscountID", OtherKey="DiscountID")]
		public EntitySet<Discount> Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				this._Discount.Assign(value);
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
		
		private void attach_Service(Service entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Service(Service entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
		
		private void attach_Client(Client entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Client(Client entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
		
		private void attach_Employee(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Employee(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
		
		private void attach_Discount(Discount entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Discount(Discount entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
}
#pragma warning restore 1591
