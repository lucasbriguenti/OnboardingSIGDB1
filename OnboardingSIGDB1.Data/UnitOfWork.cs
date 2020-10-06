﻿using OnboardingSIGDB1.Domain.Models;
using System;

namespace OnboardingSIGDB1.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _contexto;
        private Repositorio<Empresa> _empresaRepositorio = null;
        public UnitOfWork(DataContext contexto)
        {
            _contexto = contexto;
        }
        public IRepositorio<Empresa> EmpresaRepositorio
        {
            get
            {
                if(_empresaRepositorio == null)
                {
                    _empresaRepositorio = new Repositorio<Empresa>(_contexto);
                }
                return _empresaRepositorio;
            }
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _contexto.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
