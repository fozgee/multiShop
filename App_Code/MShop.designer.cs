﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="multiShop")]
public partial class MShopDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCategory(Category instance);
  partial void UpdateCategory(Category instance);
  partial void DeleteCategory(Category instance);
  partial void InsertShop(Shop instance);
  partial void UpdateShop(Shop instance);
  partial void DeleteShop(Shop instance);
  partial void InsertProduct(Product instance);
  partial void UpdateProduct(Product instance);
  partial void DeleteProduct(Product instance);
  #endregion
	
	public MShopDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["multiShopConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public MShopDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MShopDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Category> Categories
	{
		get
		{
			return this.GetTable<Category>();
		}
	}
	
	public System.Data.Linq.Table<Shop> Shops
	{
		get
		{
			return this.GetTable<Shop>();
		}
	}
	
	public System.Data.Linq.Table<Product> Products
	{
		get
		{
			return this.GetTable<Product>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private System.Nullable<int> _shop;
	
	private string _name;
	
	private string _navlink;
	
	private EntitySet<Product> _Products;
	
	private EntityRef<Shop> _Shop1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnshopChanging(System.Nullable<int> value);
    partial void OnshopChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnnavlinkChanging(string value);
    partial void OnnavlinkChanged();
    #endregion
	
	public Category()
	{
		this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
		this._Shop1 = default(EntityRef<Shop>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shop", DbType="Int")]
	public System.Nullable<int> shop
	{
		get
		{
			return this._shop;
		}
		set
		{
			if ((this._shop != value))
			{
				if (this._Shop1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnshopChanging(value);
				this.SendPropertyChanging();
				this._shop = value;
				this.SendPropertyChanged("shop");
				this.OnshopChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_navlink", DbType="NVarChar(100)")]
	public string navlink
	{
		get
		{
			return this._navlink;
		}
		set
		{
			if ((this._navlink != value))
			{
				this.OnnavlinkChanging(value);
				this.SendPropertyChanging();
				this._navlink = value;
				this.SendPropertyChanged("navlink");
				this.OnnavlinkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Products", ThisKey="id", OtherKey="category")]
	public EntitySet<Product> Products
	{
		get
		{
			return this._Products;
		}
		set
		{
			this._Products.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shop_Category", Storage="_Shop1", ThisKey="shop", OtherKey="id", IsForeignKey=true)]
	public Shop Shop1
	{
		get
		{
			return this._Shop1.Entity;
		}
		set
		{
			Shop previousValue = this._Shop1.Entity;
			if (((previousValue != value) 
						|| (this._Shop1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Shop1.Entity = null;
					previousValue.Categories.Remove(this);
				}
				this._Shop1.Entity = value;
				if ((value != null))
				{
					value.Categories.Add(this);
					this._shop = value.id;
				}
				else
				{
					this._shop = default(Nullable<int>);
				}
				this.SendPropertyChanged("Shop1");
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
	
	private void attach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Category1 = this;
	}
	
	private void detach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Category1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shop")]
public partial class Shop : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private EntitySet<Category> _Categories;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
	
	public Shop()
	{
		this._Categories = new EntitySet<Category>(new Action<Category>(this.attach_Categories), new Action<Category>(this.detach_Categories));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shop_Category", Storage="_Categories", ThisKey="id", OtherKey="shop")]
	public EntitySet<Category> Categories
	{
		get
		{
			return this._Categories;
		}
		set
		{
			this._Categories.Assign(value);
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
	
	private void attach_Categories(Category entity)
	{
		this.SendPropertyChanging();
		entity.Shop1 = this;
	}
	
	private void detach_Categories(Category entity)
	{
		this.SendPropertyChanging();
		entity.Shop1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _descrip;
	
	private string _fulldescrip;
	
	private string _buylink;
	
	private System.Nullable<int> _category;
	
	private EntityRef<Category> _Category1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescripChanging(string value);
    partial void OndescripChanged();
    partial void OnfulldescripChanging(string value);
    partial void OnfulldescripChanged();
    partial void OnbuylinkChanging(string value);
    partial void OnbuylinkChanged();
    partial void OncategoryChanging(System.Nullable<int> value);
    partial void OncategoryChanged();
    #endregion
	
	public Product()
	{
		this._Category1 = default(EntityRef<Category>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(300)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descrip", DbType="NVarChar(MAX)")]
	public string descrip
	{
		get
		{
			return this._descrip;
		}
		set
		{
			if ((this._descrip != value))
			{
				this.OndescripChanging(value);
				this.SendPropertyChanging();
				this._descrip = value;
				this.SendPropertyChanged("descrip");
				this.OndescripChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fulldescrip", DbType="NVarChar(MAX)")]
	public string fulldescrip
	{
		get
		{
			return this._fulldescrip;
		}
		set
		{
			if ((this._fulldescrip != value))
			{
				this.OnfulldescripChanging(value);
				this.SendPropertyChanging();
				this._fulldescrip = value;
				this.SendPropertyChanged("fulldescrip");
				this.OnfulldescripChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_buylink", DbType="NVarChar(300)")]
	public string buylink
	{
		get
		{
			return this._buylink;
		}
		set
		{
			if ((this._buylink != value))
			{
				this.OnbuylinkChanging(value);
				this.SendPropertyChanging();
				this._buylink = value;
				this.SendPropertyChanged("buylink");
				this.OnbuylinkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="Int")]
	public System.Nullable<int> category
	{
		get
		{
			return this._category;
		}
		set
		{
			if ((this._category != value))
			{
				if (this._Category1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OncategoryChanging(value);
				this.SendPropertyChanging();
				this._category = value;
				this.SendPropertyChanged("category");
				this.OncategoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category1", ThisKey="category", OtherKey="id", IsForeignKey=true)]
	public Category Category1
	{
		get
		{
			return this._Category1.Entity;
		}
		set
		{
			Category previousValue = this._Category1.Entity;
			if (((previousValue != value) 
						|| (this._Category1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Category1.Entity = null;
					previousValue.Products.Remove(this);
				}
				this._Category1.Entity = value;
				if ((value != null))
				{
					value.Products.Add(this);
					this._category = value.id;
				}
				else
				{
					this._category = default(Nullable<int>);
				}
				this.SendPropertyChanged("Category1");
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
#pragma warning restore 1591
