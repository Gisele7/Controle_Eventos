//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controle_Eventos
{
    using System;
    using System.Collections.Generic;
    
    public partial class CURSOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSOS()
        {
            this.ALUNOS = new HashSet<ALUNOS>();
            this.EVENTOS_CURSOS = new HashSet<EVENTOS_CURSOS>();
            this.TURMA = new HashSet<TURMA>();
        }
    
        public int CSCodigo { get; set; }
        public string CSNome { get; set; }
        public Nullable<int> CSCodEvento { get; set; }
        public Nullable<int> CSCodTipoCurso { get; set; }
        public Nullable<int> CSCodUsuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALUNOS> ALUNOS { get; set; }
        public virtual EVENTOS EVENTOS { get; set; }
        public virtual TIPO_CURSO TIPO_CURSO { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTOS_CURSOS> EVENTOS_CURSOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TURMA> TURMA { get; set; }
    }
}
