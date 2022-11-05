using Controle_Eventos.Interfaces;
using Controle_Eventos.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controle_Eventos.Repositories
{
    public class RepositoryTipoUsuario : RepositoryBase<TIPO_USUARIO>, InterfaceTipoUsuario
    {
        public RepositoryTipoUsuario(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}