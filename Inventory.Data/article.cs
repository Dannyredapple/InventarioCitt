//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class article
    {
        public int ID { get; set; }
        public string NameArticle { get; set; }
        public int Stock { get; set; }
        public string Locker { get; set; }
        public string DescriptionArticle { get; set; }
    
        public virtual request request { get; set; }
    }
}
