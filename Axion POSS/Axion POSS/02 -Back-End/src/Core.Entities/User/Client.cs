//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Entities.User
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public Client()
        {
            this.Transaction = new HashSet<Transaction>();
        }
    
        public int Id { get; set; }
        public int IdStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
