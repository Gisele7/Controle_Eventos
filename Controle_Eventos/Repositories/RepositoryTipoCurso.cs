using Controle_Eventos.Interfaces;
using Controle_Eventos.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controle_Eventos.Repositories
{
    public class RepositoryTipoCurso : RepositoryBase<TIPO_CURSO>, InterfaceTipoCurso
    {
        public RepositoryTipoCurso(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}