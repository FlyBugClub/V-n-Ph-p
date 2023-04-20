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

namespace VanPhapShared
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
    [Serializable]
    public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::VanPhapShared.Properties.Settings.Default.DataSourceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
        
        public System.Data.Linq.Table<ChiTietSo> ChiTietSos
		{
			get
			{
				return this.GetTable<ChiTietSo>();
			}
		}
		
		public System.Data.Linq.Table<DangLe> DangLes
		{
			get
			{
				return this.GetTable<DangLe>();
			}
		}
		
		public System.Data.Linq.Table<Han> Hans
		{
			get
			{
				return this.GetTable<Han>();
			}
		}
		
		public System.Data.Linq.Table<LoaiSo> LoaiSos
		{
			get
			{
				return this.GetTable<LoaiSo>();
			}
		}
		
		public System.Data.Linq.Table<Sao> Saos
		{
			get
			{
				return this.GetTable<Sao>();
			}
		}
		
		public System.Data.Linq.Table<PhatTu> PhatTus
		{
			get
			{
				return this.GetTable<PhatTu>();
			}
		}
		
		public System.Data.Linq.Table<Nam> Nams
		{
			get
			{
				return this.GetTable<Nam>();
			}
		}
		
		public System.Data.Linq.Table<LoaiLe> LoaiLes
		{
			get
			{
				return this.GetTable<LoaiLe>();
			}
		}
		
		public System.Data.Linq.Table<So> Sos
		{
			get
			{
				return this.GetTable<So>();
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietSo")]
	public partial class ChiTietSo
	{
		
		private System.Nullable<double> _ID;
		
		private System.Nullable<double> _IDSo;
		
		private string _HoTen;
		
		private string _PhapDanh;
		
		private System.Nullable<double> _NamNu;
		
		private string _NgaySinh;
		
		private System.Nullable<double> _IDNamSinh;
		
		private string _HoTen_Unicode;
		
		private string _PhapDanh_Unicode;
		
		public ChiTietSo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Float")]
		public System.Nullable<double> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDSo", DbType="Float")]
		public System.Nullable<double> IDSo
		{
			get
			{
				return this._IDSo;
			}
			set
			{
				if ((this._IDSo != value))
				{
					this._IDSo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(255)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this._HoTen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhapDanh", DbType="NVarChar(255)")]
		public string PhapDanh
		{
			get
			{
				return this._PhapDanh;
			}
			set
			{
				if ((this._PhapDanh != value))
				{
					this._PhapDanh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamNu", DbType="Float")]
		public System.Nullable<double> NamNu
		{
			get
			{
				return this._NamNu;
			}
			set
			{
				if ((this._NamNu != value))
				{
					this._NamNu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(255)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNamSinh", DbType="Float")]
		public System.Nullable<double> IDNamSinh
		{
			get
			{
				return this._IDNamSinh;
			}
			set
			{
				if ((this._IDNamSinh != value))
				{
					this._IDNamSinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen_Unicode", DbType="NVarChar(255)")]
		public string HoTen_Unicode
		{
			get
			{
				return this._HoTen_Unicode;
			}
			set
			{
				if ((this._HoTen_Unicode != value))
				{
					this._HoTen_Unicode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhapDanh_Unicode", DbType="NVarChar(255)")]
		public string PhapDanh_Unicode
		{
			get
			{
				return this._PhapDanh_Unicode;
			}
			set
			{
				if ((this._PhapDanh_Unicode != value))
				{
					this._PhapDanh_Unicode = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangLe")]
	public partial class DangLe
	{
		
		private string _ID;
		
		private System.Nullable<int> _IDLoaiLe;
		
		private System.Nullable<System.DateTime> _ThoiDiem;
		
		private System.Nullable<int> _IDSo;
		
		public DangLe()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(50)")]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLoaiLe", DbType="Int")]
		public System.Nullable<int> IDLoaiLe
		{
			get
			{
				return this._IDLoaiLe;
			}
			set
			{
				if ((this._IDLoaiLe != value))
				{
					this._IDLoaiLe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoiDiem", DbType="DateTime")]
		public System.Nullable<System.DateTime> ThoiDiem
		{
			get
			{
				return this._ThoiDiem;
			}
			set
			{
				if ((this._ThoiDiem != value))
				{
					this._ThoiDiem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDSo", DbType="Int")]
		public System.Nullable<int> IDSo
		{
			get
			{
				return this._IDSo;
			}
			set
			{
				if ((this._IDSo != value))
				{
					this._IDSo = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Han")]
	public partial class Han
	{
		
		private System.Nullable<double> _ID;
		
		private string _Han1;
		
		private string _Han_Unicode;
		
		public Han()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Float")]
		public System.Nullable<double> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Han", Storage="_Han1", DbType="NVarChar(255)")]
		public string Han1
		{
			get
			{
				return this._Han1;
			}
			set
			{
				if ((this._Han1 != value))
				{
					this._Han1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Han_Unicode", DbType="NVarChar(255)")]
		public string Han_Unicode
		{
			get
			{
				return this._Han_Unicode;
			}
			set
			{
				if ((this._Han_Unicode != value))
				{
					this._Han_Unicode = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSo")]
	public partial class LoaiSo
	{
		
		private System.Nullable<double> _ID;
		
		private string _GhiChu;
		
		private string _GhiChu_Unicode;
		
		public LoaiSo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Float")]
		public System.Nullable<double> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(255)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this._GhiChu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu_Unicode", DbType="NVarChar(255)")]
		public string GhiChu_Unicode
		{
			get
			{
				return this._GhiChu_Unicode;
			}
			set
			{
				if ((this._GhiChu_Unicode != value))
				{
					this._GhiChu_Unicode = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sao")]
	public partial class Sao
	{
		
		private System.Nullable<int> _ID;
		
		private string _Sao1;
		
		public Sao()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Sao", Storage="_Sao1", DbType="NVarChar(50)")]
		public string Sao1
		{
			get
			{
				return this._Sao1;
			}
			set
			{
				if ((this._Sao1 != value))
				{
					this._Sao1 = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhatTu")]
	public partial class PhatTu
	{
		
		private int _ID;
		
		private string _HoTen;
		
		private string _PhapDanh;
		
		private string _DiaChi;
		
		private string _NguyenQuan;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<int> _IDNamSinh;
		
		public PhatTu()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this._HoTen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhapDanh", DbType="NVarChar(50)")]
		public string PhapDanh
		{
			get
			{
				return this._PhapDanh;
			}
			set
			{
				if ((this._PhapDanh != value))
				{
					this._PhapDanh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(MAX)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this._DiaChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguyenQuan", DbType="NVarChar(MAX)")]
		public string NguyenQuan
		{
			get
			{
				return this._NguyenQuan;
			}
			set
			{
				if ((this._NguyenQuan != value))
				{
					this._NguyenQuan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
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
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNamSinh", DbType="Int")]
		public System.Nullable<int> IDNamSinh
		{
			get
			{
				return this._IDNamSinh;
			}
			set
			{
				if ((this._IDNamSinh != value))
				{
					this._IDNamSinh = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nam")]
	public partial class Nam
	{
		
		private System.Nullable<int> _ID;
		
		private System.Nullable<int> _NamDL;
		
		private string _NamAL;
		
		public Nam()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamDL", DbType="Int")]
		public System.Nullable<int> NamDL
		{
			get
			{
				return this._NamDL;
			}
			set
			{
				if ((this._NamDL != value))
				{
					this._NamDL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamAL", DbType="NVarChar(50)")]
		public string NamAL
		{
			get
			{
				return this._NamAL;
			}
			set
			{
				if ((this._NamAL != value))
				{
					this._NamAL = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiLe")]
	public partial class LoaiLe
	{
		
		private System.Nullable<int> _ID;
		
		private string _GhiChu;
		
		public LoaiLe()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this._GhiChu = value;
				}
			}
		}
	}
    [Serializable]
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.So")]
	public partial class So
	{
		
		private int _ID;
		
		private System.Nullable<int> _IDChuBai;
		
		private System.Nullable<System.DateTime> _NgayLapSo;
		
		private System.Nullable<System.DateTime> _NgayCapNhat;
		
		private System.Nullable<int> _IDLoaiSo;
		
		public So()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDChuBai", DbType="Int")]
		public System.Nullable<int> IDChuBai
		{
			get
			{
				return this._IDChuBai;
			}
			set
			{
				if ((this._IDChuBai != value))
				{
					this._IDChuBai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLapSo", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayLapSo
		{
			get
			{
				return this._NgayLapSo;
			}
			set
			{
				if ((this._NgayLapSo != value))
				{
					this._NgayLapSo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayCapNhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayCapNhat
		{
			get
			{
				return this._NgayCapNhat;
			}
			set
			{
				if ((this._NgayCapNhat != value))
				{
					this._NgayCapNhat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLoaiSo", DbType="Int")]
		public System.Nullable<int> IDLoaiSo
		{
			get
			{
				return this._IDLoaiSo;
			}
			set
			{
				if ((this._IDLoaiSo != value))
				{
					this._IDLoaiSo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
