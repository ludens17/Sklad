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
    
    public partial class Товар_Заказ
    {
        public int id { get; set; }
        public string Наименование { get; set; }
        public int IdЗаказ { get; set; }
        public int IdТовар { get; set; }
        public int колво { get; set; }
        public string едизм { get; set; }
        public decimal стоимзаед { get; set; }
    
        public virtual заказ заказ { get; set; }
        public virtual товар товар { get; set; }
    }
}
