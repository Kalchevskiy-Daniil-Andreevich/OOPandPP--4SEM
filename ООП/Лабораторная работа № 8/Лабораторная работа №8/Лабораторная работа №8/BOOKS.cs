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
    
    public partial class BOOKS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOKS()
        {
            this.EDITION = new HashSet<EDITION>();
        }
    
        public int ID_BOOK { get; set; }
        public string NAME_BOOK { get; set; }
        public Nullable<int> ID_AUTHOR { get; set; }
        public Nullable<short> THE_YEAR_OF_PUBLISHING { get; set; }
        public Nullable<short> COUNT_BOOKS { get; set; }
    
        public virtual AUTHORS AUTHORS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EDITION> EDITION { get; set; }
    }
}
