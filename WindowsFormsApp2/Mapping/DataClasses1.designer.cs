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
    partial void Insertskill(skill instance);
    partial void Updateskill(skill instance);
    partial void Deleteskill(skill instance);
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    partial void Insertps(ps instance);
    partial void Updateps(ps instance);
    partial void Deleteps(ps instance);
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
		
		public System.Data.Linq.Table<skill> skill
		{
			get
			{
				return this.GetTable<skill>();
			}
		}
		
		public System.Data.Linq.Table<employee> employee
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
		
		public System.Data.Linq.Table<ps> ps
		{
			get
			{
				return this.GetTable<ps>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.skills")]
	public partial class skill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _skill_id;
		
		private string _skill_name;
		
		private EntitySet<ps> _ps;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onskill_idChanging(long value);
    partial void Onskill_idChanged();
    partial void Onskill_nameChanging(string value);
    partial void Onskill_nameChanged();
    #endregion
		
		public skill()
		{
			this._ps = new EntitySet<ps>(new Action<ps>(this.attach_ps), new Action<ps>(this.detach_ps));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_skill_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long skill_id
		{
			get
			{
				return this._skill_id;
			}
			set
			{
				if ((this._skill_id != value))
				{
					this.Onskill_idChanging(value);
					this.SendPropertyChanging();
					this._skill_id = value;
					this.SendPropertyChanged("skill_id");
					this.Onskill_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_skill_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string skill_name
		{
			get
			{
				return this._skill_name;
			}
			set
			{
				if ((this._skill_name != value))
				{
					this.Onskill_nameChanging(value);
					this.SendPropertyChanging();
					this._skill_name = value;
					this.SendPropertyChanged("skill_name");
					this.Onskill_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="skill_ps", Storage="_ps", ThisKey="skill_id", OtherKey="skills_id")]
		public EntitySet<ps> ps
		{
			get
			{
				return this._ps;
			}
			set
			{
				this._ps.Assign(value);
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
		
		private void attach_ps(ps entity)
		{
			this.SendPropertyChanging();
			entity.skill = this;
		}
		
		private void detach_ps(ps entity)
		{
			this.SendPropertyChanging();
			entity.skill = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employees")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _employee_id;
		
		private string _first_name;
		
		private string _second_name;
		
		private string _position;
		
		private string _education;
		
		private System.Nullable<System.DateTime> _date_of_birth;
		
		private string _address;
		
		private System.Nullable<long> _passport_number;
		
		private System.Nullable<long> _phone_number;
		
		private string _mail;
		
		private EntitySet<ps> _ps;
		
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
    partial void OneducationChanging(string value);
    partial void OneducationChanged();
    partial void Ondate_of_birthChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_of_birthChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void Onpassport_numberChanging(System.Nullable<long> value);
    partial void Onpassport_numberChanged();
    partial void Onphone_numberChanging(System.Nullable<long> value);
    partial void Onphone_numberChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    #endregion
		
		public employee()
		{
			this._ps = new EntitySet<ps>(new Action<ps>(this.attach_ps), new Action<ps>(this.detach_ps));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_education", DbType="VarChar(50)")]
		public string education
		{
			get
			{
				return this._education;
			}
			set
			{
				if ((this._education != value))
				{
					this.OneducationChanging(value);
					this.SendPropertyChanging();
					this._education = value;
					this.SendPropertyChanged("education");
					this.OneducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[date of birth]", Storage="_date_of_birth", DbType="Date")]
		public System.Nullable<System.DateTime> date_of_birth
		{
			get
			{
				return this._date_of_birth;
			}
			set
			{
				if ((this._date_of_birth != value))
				{
					this.Ondate_of_birthChanging(value);
					this.SendPropertyChanging();
					this._date_of_birth = value;
					this.SendPropertyChanged("date_of_birth");
					this.Ondate_of_birthChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[passport number]", Storage="_passport_number", DbType="BigInt")]
		public System.Nullable<long> passport_number
		{
			get
			{
				return this._passport_number;
			}
			set
			{
				if ((this._passport_number != value))
				{
					this.Onpassport_numberChanging(value);
					this.SendPropertyChanging();
					this._passport_number = value;
					this.SendPropertyChanged("passport_number");
					this.Onpassport_numberChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employee_ps", Storage="_ps", ThisKey="employee_id", OtherKey="person_id")]
		public EntitySet<ps> ps
		{
			get
			{
				return this._ps;
			}
			set
			{
				this._ps.Assign(value);
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
		
		private void attach_ps(ps entity)
		{
			this.SendPropertyChanging();
			entity.employee = this;
		}
		
		private void detach_ps(ps entity)
		{
			this.SendPropertyChanging();
			entity.employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ps")]
	public partial class ps : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ps_id;
		
		private long _person_id;
		
		private long _skills_id;
		
		private EntityRef<employee> _employee;
		
		private EntityRef<skill> _skill;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onps_idChanging(long value);
    partial void Onps_idChanged();
    partial void Onperson_idChanging(long value);
    partial void Onperson_idChanged();
    partial void Onskills_idChanging(long value);
    partial void Onskills_idChanged();
    #endregion
		
		public ps()
		{
			this._employee = default(EntityRef<employee>);
			this._skill = default(EntityRef<skill>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ps_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ps_id
		{
			get
			{
				return this._ps_id;
			}
			set
			{
				if ((this._ps_id != value))
				{
					this.Onps_idChanging(value);
					this.SendPropertyChanging();
					this._ps_id = value;
					this.SendPropertyChanged("ps_id");
					this.Onps_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_person_id", DbType="BigInt NOT NULL")]
		public long person_id
		{
			get
			{
				return this._person_id;
			}
			set
			{
				if ((this._person_id != value))
				{
					if (this._employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onperson_idChanging(value);
					this.SendPropertyChanging();
					this._person_id = value;
					this.SendPropertyChanged("person_id");
					this.Onperson_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_skills_id", DbType="BigInt NOT NULL")]
		public long skills_id
		{
			get
			{
				return this._skills_id;
			}
			set
			{
				if ((this._skills_id != value))
				{
					if (this._skill.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onskills_idChanging(value);
					this.SendPropertyChanging();
					this._skills_id = value;
					this.SendPropertyChanged("skills_id");
					this.Onskills_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employee_ps", Storage="_employee", ThisKey="person_id", OtherKey="employee_id", IsForeignKey=true)]
		public employee employee
		{
			get
			{
				return this._employee.Entity;
			}
			set
			{
				employee previousValue = this._employee.Entity;
				if (((previousValue != value) 
							|| (this._employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._employee.Entity = null;
						previousValue.ps.Remove(this);
					}
					this._employee.Entity = value;
					if ((value != null))
					{
						value.ps.Add(this);
						this._person_id = value.employee_id;
					}
					else
					{
						this._person_id = default(long);
					}
					this.SendPropertyChanged("employee");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="skill_ps", Storage="_skill", ThisKey="skills_id", OtherKey="skill_id", IsForeignKey=true)]
		public skill skill
		{
			get
			{
				return this._skill.Entity;
			}
			set
			{
				skill previousValue = this._skill.Entity;
				if (((previousValue != value) 
							|| (this._skill.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._skill.Entity = null;
						previousValue.ps.Remove(this);
					}
					this._skill.Entity = value;
					if ((value != null))
					{
						value.ps.Add(this);
						this._skills_id = value.skill_id;
					}
					else
					{
						this._skills_id = default(long);
					}
					this.SendPropertyChanged("skill");
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
