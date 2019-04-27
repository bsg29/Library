//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rimid.Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookPrint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookPrint()
        {
            this.ClientLog = new HashSet<ClientLog>();
        }
    
        public int Id { get; set; }
        public System.DateTime PublishDate { get; set; }
        public int PublisherId { get; set; }
        public decimal Price { get; set; }
        public int BookId { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLog> ClientLog { get; set; }
    }
}
