﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace GeneticAlgorithm
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class ShopDbEntities : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект ShopDbEntities, используя строку соединения из раздела "ShopDbEntities" файла конфигурации приложения.
        /// </summary>
        public ShopDbEntities() : base("name=ShopDbEntities", "ShopDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта ShopDbEntities.
        /// </summary>
        public ShopDbEntities(string connectionString) : base(connectionString, "ShopDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта ShopDbEntities.
        /// </summary>
        public ShopDbEntities(EntityConnection connection) : base(connection, "ShopDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Arcticle> Arcticles
        {
            get
            {
                if ((_Arcticles == null))
                {
                    _Arcticles = base.CreateObjectSet<Arcticle>("Arcticles");
                }
                return _Arcticles;
            }
        }
        private ObjectSet<Arcticle> _Arcticles;

        #endregion

        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Arcticles. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToArcticles(Arcticle arcticle)
        {
            base.AddObject("Arcticles", arcticle);
        }

        #endregion

    }

    #endregion

    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ShopDbModel", Name="Arcticle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Arcticle : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Arcticle.
        /// </summary>
        /// <param name="relevance">Исходное значение свойства Relevance.</param>
        /// <param name="price">Исходное значение свойства Price.</param>
        /// <param name="profit">Исходное значение свойства Profit.</param>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="count">Исходное значение свойства Count.</param>
        /// <param name="category">Исходное значение свойства Category.</param>
        public static Arcticle CreateArcticle(global::System.Int32 relevance, global::System.Int32 price, global::System.Int32 profit, global::System.Int32 id, global::System.Int32 count, global::System.Int32 category)
        {
            Arcticle arcticle = new Arcticle();
            arcticle.Relevance = relevance;
            arcticle.Price = price;
            arcticle.Profit = profit;
            arcticle.Id = id;
            arcticle.Count = count;
            arcticle.Category = category;
            return arcticle;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Relevance
        {
            get
            {
                return _Relevance;
            }
            set
            {
                OnRelevanceChanging(value);
                ReportPropertyChanging("Relevance");
                _Relevance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Relevance");
                OnRelevanceChanged();
            }
        }
        private global::System.Int32 _Relevance;
        partial void OnRelevanceChanging(global::System.Int32 value);
        partial void OnRelevanceChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Int32 _Price;
        partial void OnPriceChanging(global::System.Int32 value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Profit
        {
            get
            {
                return _Profit;
            }
            set
            {
                OnProfitChanging(value);
                ReportPropertyChanging("Profit");
                _Profit = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Profit");
                OnProfitChanged();
            }
        }
        private global::System.Int32 _Profit;
        partial void OnProfitChanging(global::System.Int32 value);
        partial void OnProfitChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Count
        {
            get
            {
                return _Count;
            }
            set
            {
                OnCountChanging(value);
                ReportPropertyChanging("Count");
                _Count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Count");
                OnCountChanged();
            }
        }
        private global::System.Int32 _Count;
        partial void OnCountChanging(global::System.Int32 value);
        partial void OnCountChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Category
        {
            get
            {
                return _Category;
            }
            set
            {
                OnCategoryChanging(value);
                ReportPropertyChanging("Category");
                _Category = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Category");
                OnCategoryChanged();
            }
        }
        private global::System.Int32 _Category;
        partial void OnCategoryChanging(global::System.Int32 value);
        partial void OnCategoryChanged();

        #endregion

    
    }

    #endregion

    
}
