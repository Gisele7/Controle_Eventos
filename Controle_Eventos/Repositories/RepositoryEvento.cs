using Controle_Eventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controle_Eventos.Repositorys
{
    public class RepositoryEvento : RepositoryBase<EVENTOS>, InterfaceEvento
    {
        public RepositoryEvento(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}