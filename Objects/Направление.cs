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
    /// Направление.
    /// </summary>
    // *** Start programmer edit section *** (Направление CustomAttributes)

    // *** End programmer edit section *** (Направление CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("НаправлениеE", new string[] {
            "Название as \'Название\'",
            "Факультет as \'Факультет\'"})]
    [MasterViewDefineAttribute("НаправлениеE", "Факультет", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("НаправлениеL", new string[] {
            "Название as \'Направление\'",
            "Факультет.Название as \'Факультет\'"})]
    public class Направление : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private IIS.Rating.Факультет fФакультет;
        
        // *** Start programmer edit section *** (Направление CustomMembers)

        // *** End programmer edit section *** (Направление CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Направление.Название CustomAttributes)

        // *** End programmer edit section *** (Направление.Название CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Направление.Название Get start)

                // *** End programmer edit section *** (Направление.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Направление.Название Get end)

                // *** End programmer edit section *** (Направление.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Направление.Название Set start)

                // *** End programmer edit section *** (Направление.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Направление.Название Set end)

                // *** End programmer edit section *** (Направление.Название Set end)
            }
        }
        
        /// <summary>
        /// Направление.
        /// </summary>
        // *** Start programmer edit section *** (Направление.Факультет CustomAttributes)

        // *** End programmer edit section *** (Направление.Факультет CustomAttributes)
        [PropertyStorage(new string[] {
                "Факультет"})]
        [NotNull()]
        public virtual IIS.Rating.Факультет Факультет
        {
            get
            {
                // *** Start programmer edit section *** (Направление.Факультет Get start)

                // *** End programmer edit section *** (Направление.Факультет Get start)
                IIS.Rating.Факультет result = this.fФакультет;
                // *** Start programmer edit section *** (Направление.Факультет Get end)

                // *** End programmer edit section *** (Направление.Факультет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Направление.Факультет Set start)

                // *** End programmer edit section *** (Направление.Факультет Set start)
                this.fФакультет = value;
                // *** Start programmer edit section *** (Направление.Факультет Set end)

                // *** End programmer edit section *** (Направление.Факультет Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "НаправлениеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View НаправлениеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("НаправлениеE", typeof(IIS.Rating.Направление));
                }
            }
            
            /// <summary>
            /// "НаправлениеL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View НаправлениеL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("НаправлениеL", typeof(IIS.Rating.Направление));
                }
            }
        }
    }
}
