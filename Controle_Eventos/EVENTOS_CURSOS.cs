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
    
    public partial class EVENTOS_CURSOS
    {
        public int ECCodEvento { get; set; }
        public int ECCodCurso { get; set; }
        public Nullable<System.DateTime> ECData { get; set; }
        public int ECCodAluno { get; set; }
        public bool ECConfirmado { get; set; }
    
        public virtual ALUNOS ALUNOS { get; set; }
        public virtual CURSOS CURSOS { get; set; }
        public virtual EVENTOS EVENTOS { get; set; }
    }
}
