//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Лабораторная_работа__8
{
    using System;
    using System.Collections.Generic;
    
    public partial class EDITION
    {
        public int ID_EDITION { get; set; }
        public Nullable<int> ID_BOOK { get; set; }
        public Nullable<short> DATE_EDITION { get; set; }
        public Nullable<short> DATE_SURRENDER { get; set; }
    
        public virtual BOOKS BOOKS { get; set; }
    }
}
