//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BOOKS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOKS()
        {
            this.EDITION = new HashSet<EDITION>();
        }

        [Key]
        public int ID_BOOK { get; set; }
        public string NAME_BOOK { get; set; }
        public Nullable<int> ID_AUTHOR { get; set; }
        public Nullable<int> THE_YEAR_OF_PUBLISHING { get; set; }
        public Nullable<int> COUNT_BOOKS { get; set; }
        [ForeignKey("ID_AUTHOR")]
        public virtual AUTHORS AUTHORS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EDITION> EDITION { get; set; }
    }
}
