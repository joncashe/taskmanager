﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ProyectoSaaSCRM.ORM
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SaaSCRMEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SaaSCRMEntities object using the connection string found in the 'SaaSCRMEntities' section of the application configuration file.
        /// </summary>
        public SaaSCRMEntities() : base("name=SaaSCRMEntities", "SaaSCRMEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SaaSCRMEntities object.
        /// </summary>
        public SaaSCRMEntities(string connectionString) : base(connectionString, "SaaSCRMEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SaaSCRMEntities object.
        /// </summary>
        public SaaSCRMEntities(EntityConnection connection) : base(connection, "SaaSCRMEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Task> Tasks
        {
            get
            {
                if ((_Tasks == null))
                {
                    _Tasks = base.CreateObjectSet<Task>("Tasks");
                }
                return _Tasks;
            }
        }
        private ObjectSet<Task> _Tasks;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tasks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTasks(Task task)
        {
            base.AddObject("Tasks", task);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SaaSCRMModel", Name="Task")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Task : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Task object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="start_date">Initial value of the start_date property.</param>
        /// <param name="due_date">Initial value of the due_date property.</param>
        public static Task CreateTask(global::System.Int32 id, global::System.String name, global::System.DateTime start_date, global::System.DateTime due_date)
        {
            Task task = new Task();
            task.id = id;
            task.name = name;
            task.start_date = start_date;
            task.due_date = due_date;
            return task;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime start_date
        {
            get
            {
                return _start_date;
            }
            set
            {
                Onstart_dateChanging(value);
                ReportPropertyChanging("start_date");
                _start_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("start_date");
                Onstart_dateChanged();
            }
        }
        private global::System.DateTime _start_date;
        partial void Onstart_dateChanging(global::System.DateTime value);
        partial void Onstart_dateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime due_date
        {
            get
            {
                return _due_date;
            }
            set
            {
                Ondue_dateChanging(value);
                ReportPropertyChanging("due_date");
                _due_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("due_date");
                Ondue_dateChanged();
            }
        }
        private global::System.DateTime _due_date;
        partial void Ondue_dateChanging(global::System.DateTime value);
        partial void Ondue_dateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> completion_date
        {
            get
            {
                return _completion_date;
            }
            set
            {
                Oncompletion_dateChanging(value);
                ReportPropertyChanging("completion_date");
                _completion_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("completion_date");
                Oncompletion_dateChanged();
            }
        }
        private Nullable<global::System.DateTime> _completion_date;
        partial void Oncompletion_dateChanging(Nullable<global::System.DateTime> value);
        partial void Oncompletion_dateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String comments
        {
            get
            {
                return _comments;
            }
            set
            {
                OncommentsChanging(value);
                ReportPropertyChanging("comments");
                _comments = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("comments");
                OncommentsChanged();
            }
        }
        private global::System.String _comments;
        partial void OncommentsChanging(global::System.String value);
        partial void OncommentsChanged();

        #endregion
    
    }

    #endregion
    
}
