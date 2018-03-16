﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Rating
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;


    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Заявление.
    /// </summary>
    // *** Start programmer edit section *** (Заявление CustomAttributes)
    
    // *** End programmer edit section *** (Заявление CustomAttributes)
    [AutoAltered()]
    [LoadingOrder(new string[] {
            ""})]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаявлениеE", new string[] {
            "Абитуриент as \'Абитуриент\' on \'-Абитуриент\'",
            "Абитуриент.Имя on \'-Абитуриент\'",
            "Абитуриент.Отчество on \'-Абитуриент\'",
            "Абитуриент.СреднийБаллАттестата as \'Аттестат\' on \'-Абитуриент\'",
            "Абитуриент.Эссе as \'Эссе\' on \'-Абитуриент\'",
            "Абитуриент.ДопБаллы as \'Доп.баллы\' on \'-Абитуриент\'",
            "Оценка1 as \'Оценка1\' on \'-Заявление\'",
            "Оценка2 as \'Оценка2\' on \'-Заявление\'",
            "Оценка3 as \'Оценка3\' on \'-Заявление\'",
            "Направление as \'Направление\' on \'-Заявление\'",
            "ФормаОбучения as \'Форма обучения\' on \'-Заявление\'",
            "ТипДокументов as \'Тип документов\' on \'-Заявление\'",
            "Приоритет as \'Приоритет\' on \'-Заявление\'"})]
    [MasterViewDefineAttribute("ЗаявлениеE", "Абитуриент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [MasterViewDefineAttribute("ЗаявлениеE", "Направление", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [MasterViewDefineAttribute("ЗаявлениеE", "ФормаОбучения", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [MasterViewDefineAttribute("ЗаявлениеE", "ТипДокументов", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("ЗаявлениеL", new string[] {
            "Абитуриент.Фамилия as \'Фамилия\'",
            "Абитуриент.Имя as \'Имя\'",
            "Абитуриент.Отчество as \'Отчество\'",
            "Направление.Название as \'Направление\'",
            "ТипДокументов.Название as \'Документы\'",
            "ФормаОбучения.Название as \'Форма обучения\'",
            "Оценка1 as \'Оценка1\'",
            "Оценка2 as \'Оценка2\'",
            "Оценка3 as \'Оценка3\'",
            "Сумма as \'Сумма баллов\'",
            "Приоритет as \'Приоритет\'"})]
    public class Заявление : ICSSoft.STORMNET.DataObject
    {
        
        private int fПриоритет;
        
        private int fОценка1;
        
        private int fОценка2;
        
        private int fОценка3;
        
        private int fОценка4;
        
        private IIS.Rating.Абитуриент fАбитуриент;
        
        private IIS.Rating.ТипДокументов fТипДокументов;
        
        private IIS.Rating.ФормаОбучения fФормаОбучения;
        
        private IIS.Rating.Направление fНаправление;
        
        // *** Start programmer edit section *** (Заявление CustomMembers)

        // *** End programmer edit section *** (Заявление CustomMembers)

        
        /// <summary>
        /// Приоритет.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Приоритет CustomAttributes)

        // *** End programmer edit section *** (Заявление.Приоритет CustomAttributes)
        public virtual int Приоритет
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Приоритет Get start)

                // *** End programmer edit section *** (Заявление.Приоритет Get start)
                int result = this.fПриоритет;
                // *** Start programmer edit section *** (Заявление.Приоритет Get end)

                // *** End programmer edit section *** (Заявление.Приоритет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Приоритет Set start)

                // *** End programmer edit section *** (Заявление.Приоритет Set start)
                this.fПриоритет = value;
                // *** Start programmer edit section *** (Заявление.Приоритет Set end)

                // *** End programmer edit section *** (Заявление.Приоритет Set end)
            }
        }
        
        /// <summary>
        /// Оценка1.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Оценка1 CustomAttributes)

        // *** End programmer edit section *** (Заявление.Оценка1 CustomAttributes)
        [NotNull()]
        public virtual int Оценка1
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Оценка1 Get start)

                // *** End programmer edit section *** (Заявление.Оценка1 Get start)
                int result = this.fОценка1;
                // *** Start programmer edit section *** (Заявление.Оценка1 Get end)

                // *** End programmer edit section *** (Заявление.Оценка1 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Оценка1 Set start)

                // *** End programmer edit section *** (Заявление.Оценка1 Set start)
                this.fОценка1 = value;
                // *** Start programmer edit section *** (Заявление.Оценка1 Set end)

                // *** End programmer edit section *** (Заявление.Оценка1 Set end)
            }
        }
        
        /// <summary>
        /// Оценка2.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Оценка2 CustomAttributes)

        // *** End programmer edit section *** (Заявление.Оценка2 CustomAttributes)
        [NotNull()]
        public virtual int Оценка2
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Оценка2 Get start)

                // *** End programmer edit section *** (Заявление.Оценка2 Get start)
                int result = this.fОценка2;
                // *** Start programmer edit section *** (Заявление.Оценка2 Get end)

                // *** End programmer edit section *** (Заявление.Оценка2 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Оценка2 Set start)

                // *** End programmer edit section *** (Заявление.Оценка2 Set start)
                this.fОценка2 = value;
                // *** Start programmer edit section *** (Заявление.Оценка2 Set end)

                // *** End programmer edit section *** (Заявление.Оценка2 Set end)
            }
        }
        
        /// <summary>
        /// Оценка3.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Оценка3 CustomAttributes)

        // *** End programmer edit section *** (Заявление.Оценка3 CustomAttributes)
        [NotNull()]
        public virtual int Оценка3
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Оценка3 Get start)

                // *** End programmer edit section *** (Заявление.Оценка3 Get start)
                int result = this.fОценка3;
                // *** Start programmer edit section *** (Заявление.Оценка3 Get end)

                // *** End programmer edit section *** (Заявление.Оценка3 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Оценка3 Set start)

                // *** End programmer edit section *** (Заявление.Оценка3 Set start)
                this.fОценка3 = value;
                // *** Start programmer edit section *** (Заявление.Оценка3 Set end)

                // *** End programmer edit section *** (Заявление.Оценка3 Set end)
            }
        }
        
        /// <summary>
        /// Оценка4.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Оценка4 CustomAttributes)

        // *** End programmer edit section *** (Заявление.Оценка4 CustomAttributes)
        public virtual int Оценка4
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Оценка4 Get start)

                // *** End programmer edit section *** (Заявление.Оценка4 Get start)
                int result = this.fОценка4;
                // *** Start programmer edit section *** (Заявление.Оценка4 Get end)

                // *** End programmer edit section *** (Заявление.Оценка4 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Оценка4 Set start)

                // *** End programmer edit section *** (Заявление.Оценка4 Set start)
                this.fОценка4 = value;
                // *** Start programmer edit section *** (Заявление.Оценка4 Set end)

                // *** End programmer edit section *** (Заявление.Оценка4 Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Сумма CustomAttributes)

        // *** End programmer edit section *** (Заявление.Сумма CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.SQLDataService), "SELECT    tt.\"Оценка1\" + tt.\"Оценка2\"+tt.\"Оценка3\" AS \"Сумма\" " + "FROM \"Заявление\" tt " + "WHERE tt.primaryKey=StormMainObjectKey")]
            public virtual int Сумма
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Сумма Get)

                return 0;
                // *** End programmer edit section *** (Заявление.Сумма Get)
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Сумма Set)

                // *** End programmer edit section *** (Заявление.Сумма Set)
            }
        }
        
        /// <summary>
        /// Заявление.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Абитуриент CustomAttributes)

        // *** End programmer edit section *** (Заявление.Абитуриент CustomAttributes)
        [PropertyStorage(new string[] {
                "Абитуриент"})]
        [NotNull()]
        public virtual IIS.Rating.Абитуриент Абитуриент
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Абитуриент Get start)

                // *** End programmer edit section *** (Заявление.Абитуриент Get start)
                IIS.Rating.Абитуриент result = this.fАбитуриент;
                // *** Start programmer edit section *** (Заявление.Абитуриент Get end)

                // *** End programmer edit section *** (Заявление.Абитуриент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Абитуриент Set start)

                // *** End programmer edit section *** (Заявление.Абитуриент Set start)
                this.fАбитуриент = value;
                // *** Start programmer edit section *** (Заявление.Абитуриент Set end)

                // *** End programmer edit section *** (Заявление.Абитуриент Set end)
            }
        }
        
        /// <summary>
        /// Заявление.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.ТипДокументов CustomAttributes)

        // *** End programmer edit section *** (Заявление.ТипДокументов CustomAttributes)
        [PropertyStorage(new string[] {
                "ТипДокументов"})]
        [NotNull()]
        public virtual IIS.Rating.ТипДокументов ТипДокументов
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.ТипДокументов Get start)

                // *** End programmer edit section *** (Заявление.ТипДокументов Get start)
                IIS.Rating.ТипДокументов result = this.fТипДокументов;
                // *** Start programmer edit section *** (Заявление.ТипДокументов Get end)

                // *** End programmer edit section *** (Заявление.ТипДокументов Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.ТипДокументов Set start)

                // *** End programmer edit section *** (Заявление.ТипДокументов Set start)
                this.fТипДокументов = value;
                // *** Start programmer edit section *** (Заявление.ТипДокументов Set end)

                // *** End programmer edit section *** (Заявление.ТипДокументов Set end)
            }
        }
        
        /// <summary>
        /// Заявление.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.ФормаОбучения CustomAttributes)

        // *** End programmer edit section *** (Заявление.ФормаОбучения CustomAttributes)
        [PropertyStorage(new string[] {
                "ФормаОбучения"})]
        [NotNull()]
        public virtual IIS.Rating.ФормаОбучения ФормаОбучения
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.ФормаОбучения Get start)

                // *** End programmer edit section *** (Заявление.ФормаОбучения Get start)
                IIS.Rating.ФормаОбучения result = this.fФормаОбучения;
                // *** Start programmer edit section *** (Заявление.ФормаОбучения Get end)

                // *** End programmer edit section *** (Заявление.ФормаОбучения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.ФормаОбучения Set start)

                // *** End programmer edit section *** (Заявление.ФормаОбучения Set start)
                this.fФормаОбучения = value;
                // *** Start programmer edit section *** (Заявление.ФормаОбучения Set end)

                // *** End programmer edit section *** (Заявление.ФормаОбучения Set end)
            }
        }
        
        /// <summary>
        /// Заявление.
        /// </summary>
        // *** Start programmer edit section *** (Заявление.Направление CustomAttributes)

        // *** End programmer edit section *** (Заявление.Направление CustomAttributes)
        [PropertyStorage(new string[] {
                "Направление"})]
        [NotNull()]
        public virtual IIS.Rating.Направление Направление
        {
            get
            {
                // *** Start programmer edit section *** (Заявление.Направление Get start)

                // *** End programmer edit section *** (Заявление.Направление Get start)
                IIS.Rating.Направление result = this.fНаправление;
                // *** Start programmer edit section *** (Заявление.Направление Get end)

                // *** End programmer edit section *** (Заявление.Направление Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявление.Направление Set start)

                // *** End programmer edit section *** (Заявление.Направление Set start)
                this.fНаправление = value;
                // *** Start programmer edit section *** (Заявление.Направление Set end)

                // *** End programmer edit section *** (Заявление.Направление Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаявлениеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявлениеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявлениеE", typeof(IIS.Rating.Заявление));
                }
            }
            
            /// <summary>
            /// "ЗаявлениеL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявлениеL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявлениеL", typeof(IIS.Rating.Заявление));
                }
            }
        }
    }
}
