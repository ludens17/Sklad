//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Статистика_Операторы
    {
        public int id { get; set; }
        public int idоператор { get; set; }
        public System.DateTime ДатаВремяВхода { get; set; }
        public System.DateTime ДатаВыхода { get; set; }
    
        public virtual Операторы Операторы { get; set; }
    }
}
