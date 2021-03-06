#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLNhanVien")]
	public partial class QLNVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertPhongBan(PhongBan instance);
    partial void UpdatePhongBan(PhongBan instance);
    partial void DeletePhongBan(PhongBan instance);
    #endregion
		
		public QLNVDataContext() : 
				base(global::QLNS.Properties.Settings.Default.QLNhanVienConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLNVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<PhongBan> PhongBans
		{
			get
			{
				return this.GetTable<PhongBan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _TenNV;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<bool> _GioiTinh;
		
		private string _SoDT;
		
		private string _MaPB;
		
		private string _Picture;
		
		private EntityRef<PhongBan> _PhongBan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(System.Nullable<bool> value);
    partial void OnGioiTinhChanged();
    partial void OnSoDTChanging(string value);
    partial void OnSoDTChanged();
    partial void OnMaPBChanging(string value);
    partial void OnMaPBChanged();
    partial void OnPictureChanging(string value);
    partial void OnPictureChanged();
    #endregion
		
		public NhanVien()
		{
			this._PhongBan = default(EntityRef<PhongBan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit")]
		public System.Nullable<bool> GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDT", DbType="NChar(10)")]
		public string SoDT
		{
			get
			{
				return this._SoDT;
			}
			set
			{
				if ((this._SoDT != value))
				{
					this.OnSoDTChanging(value);
					this.SendPropertyChanging();
					this._SoDT = value;
					this.SendPropertyChanged("SoDT");
					this.OnSoDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPB", DbType="NChar(5)")]
		public string MaPB
		{
			get
			{
				return this._MaPB;
			}
			set
			{
				if ((this._MaPB != value))
				{
					if (this._PhongBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPBChanging(value);
					this.SendPropertyChanging();
					this._MaPB = value;
					this.SendPropertyChanged("MaPB");
					this.OnMaPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="NChar(30)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_NhanVien", Storage="_PhongBan", ThisKey="MaPB", OtherKey="MaPB", IsForeignKey=true)]
		public PhongBan PhongBan
		{
			get
			{
				return this._PhongBan.Entity;
			}
			set
			{
				PhongBan previousValue = this._PhongBan.Entity;
				if (((previousValue != value) 
							|| (this._PhongBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PhongBan.Entity = null;
						previousValue.NhanViens.Remove(this);
					}
					this._PhongBan.Entity = value;
					if ((value != null))
					{
						value.NhanViens.Add(this);
						this._MaPB = value.MaPB;
					}
					else
					{
						this._MaPB = default(string);
					}
					this.SendPropertyChanged("PhongBan");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhongBan")]
	public partial class PhongBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPB;
		
		private string _TenPB;
		
		private EntitySet<NhanVien> _NhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPBChanging(string value);
    partial void OnMaPBChanged();
    partial void OnTenPBChanging(string value);
    partial void OnTenPBChanged();
    #endregion
		
		public PhongBan()
		{
			this._NhanViens = new EntitySet<NhanVien>(new Action<NhanVien>(this.attach_NhanViens), new Action<NhanVien>(this.detach_NhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPB", DbType="NChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPB
		{
			get
			{
				return this._MaPB;
			}
			set
			{
				if ((this._MaPB != value))
				{
					this.OnMaPBChanging(value);
					this.SendPropertyChanging();
					this._MaPB = value;
					this.SendPropertyChanged("MaPB");
					this.OnMaPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPB", DbType="NChar(50)")]
		public string TenPB
		{
			get
			{
				return this._TenPB;
			}
			set
			{
				if ((this._TenPB != value))
				{
					this.OnTenPBChanging(value);
					this.SendPropertyChanging();
					this._TenPB = value;
					this.SendPropertyChanged("TenPB");
					this.OnTenPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_NhanVien", Storage="_NhanViens", ThisKey="MaPB", OtherKey="MaPB")]
		public EntitySet<NhanVien> NhanViens
		{
			get
			{
				return this._NhanViens;
			}
			set
			{
				this._NhanViens.Assign(value);
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
		
		private void attach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = this;
		}
		
		private void detach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = null;
		}
	}
}
#pragma warning restore 1591
