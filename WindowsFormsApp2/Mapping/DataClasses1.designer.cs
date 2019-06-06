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

namespace TestTask.Mapping
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TutorialDB")]
	public partial class DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Insertemployees(employees instance);
    partial void Updateemployees(employees instance);
    partial void Deleteemployees(employees instance);
    #endregion
		
		public DataContext() : 
				base(global::TestTask.Properties.Settings.Default.TutorialDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employees> employees
		{
			get
			{
				return this.GetTable<employees>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employees")]
	public partial class employees : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _employee_id;
		
		private string _first_name;
		
		private string _second_name;
		
		private string _position;
		
		private string _education_level;
		
		private System.Nullable<System.DateTime> _year_of_birth;
		
		private string _address;
		
		private System.Nullable<long> _pasport_number;
		
		private System.Nullable<long> _phone_number;
		
		private string _mail;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onemployee_idChanging(long value);
    partial void Onemployee_idChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onsecond_nameChanging(string value);
    partial void Onsecond_nameChanged();
    partial void OnpositionChanging(string value);
    partial void OnpositionChanged();
    partial void Oneducation_levelChanging(string value);
    partial void Oneducation_levelChanged();
    partial void Onyear_of_birthChanging(System.Nullable<System.DateTime> value);
    partial void Onyear_of_birthChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void Onpasport_numberChanging(System.Nullable<long> value);
    partial void Onpasport_numberChanged();
    partial void Onphone_numberChanging(System.Nullable<long> value);
    partial void Onphone_numberChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    #endregion
		
		public employees()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long employee_id
		{
			get
			{
				return this._employee_id;
			}
			set
			{
				if ((this._employee_id != value))
				{
					this.Onemployee_idChanging(value);
					this.SendPropertyChanging();
					this._employee_id = value;
					this.SendPropertyChanged("employee_id");
					this.Onemployee_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[first name]", Storage="_first_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[second name]", Storage="_second_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string second_name
		{
			get
			{
				return this._second_name;
			}
			set
			{
				if ((this._second_name != value))
				{
					this.Onsecond_nameChanging(value);
					this.SendPropertyChanging();
					this._second_name = value;
					this.SendPropertyChanged("second_name");
					this.Onsecond_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[education level]", Storage="_education_level", DbType="VarChar(50)")]
		public string education_level
		{
			get
			{
				return this._education_level;
			}
			set
			{
				if ((this._education_level != value))
				{
					this.Oneducation_levelChanging(value);
					this.SendPropertyChanging();
					this._education_level = value;
					this.SendPropertyChanged("education_level");
					this.Oneducation_levelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[year of birth]", Storage="_year_of_birth", DbType="Date")]
		public System.Nullable<System.DateTime> year_of_birth
		{
			get
			{
				return this._year_of_birth;
			}
			set
			{
				if ((this._year_of_birth != value))
				{
					this.Onyear_of_birthChanging(value);
					this.SendPropertyChanging();
					this._year_of_birth = value;
					this.SendPropertyChanged("year_of_birth");
					this.Onyear_of_birthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[pasport number]", Storage="_pasport_number", DbType="BigInt")]
		public System.Nullable<long> pasport_number
		{
			get
			{
				return this._pasport_number;
			}
			set
			{
				if ((this._pasport_number != value))
				{
					this.Onpasport_numberChanging(value);
					this.SendPropertyChanging();
					this._pasport_number = value;
					this.SendPropertyChanged("pasport_number");
					this.Onpasport_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[phone number]", Storage="_phone_number", DbType="BigInt")]
		public System.Nullable<long> phone_number
		{
			get
			{
				return this._phone_number;
			}
			set
			{
				if ((this._phone_number != value))
				{
					this.Onphone_numberChanging(value);
					this.SendPropertyChanging();
					this._phone_number = value;
					this.SendPropertyChanged("phone_number");
					this.Onphone_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="VarChar(50)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
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