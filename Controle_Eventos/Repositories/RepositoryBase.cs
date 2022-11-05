using Controle_Eventos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Controle_Eventos.Repositorys
{

    public class RepositoryBase<T> : InterfaceModel<T>, IDisposable where T : class
    {
        protected CONTROLE_EVENTOSEntities _DataContext;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _DataContext = new CONTROLE_EVENTOSEntities();
        }

        public T Alterar(T objeto)
        {
            _DataContext.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _DataContext.SaveChanges();
            }
            return objeto;
        }

        public void Dispose()
        {
            _DataContext.Dispose();
        }

        public void Excluir(T objeto)
        {
            _DataContext.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _DataContext.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            _DataContext.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _DataContext.SaveChanges();
            }
            return objeto;
        }

        public void SaveChanges()
        {
            _DataContext.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _DataContext.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _DataContext.Set<T>().ToList();
        }
    }
}