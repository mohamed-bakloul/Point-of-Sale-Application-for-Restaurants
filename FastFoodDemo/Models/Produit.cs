//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFoodDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.DetailsCommandeImprimante = new HashSet<DetailsCommandeImprimante>();
        }
    
        public int Id_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public Nullable<int> Id_CategorieProduit { get; set; }
        public decimal Prix_Normal { get; set; }
        public byte[] Image_Produit { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailsCommandeImprimante> DetailsCommandeImprimante { get; set; }
    }
}