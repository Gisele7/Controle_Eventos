using Controle_Eventos.Interfaces;
using Controle_Eventos.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controle_Eventos.Repositories
{
    public class RepositoryCurso : RepositoryBase<CURSOS>, InterfaceCurso
    {
        public RepositoryCurso(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}