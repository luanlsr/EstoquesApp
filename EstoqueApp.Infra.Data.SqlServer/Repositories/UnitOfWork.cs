using EstoqueApp.Domain.Interfaces.Repositories;
using EstoqueApp.Infra.Data.SqlServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext? _dateContext;

        public UnitOfWork(DataContext dateContext)
        {
            _dateContext = dateContext;
        }

        public IProdutoRepository? ProdutoRepository => new ProdutoRepository(_dateContext);

        public IEstoqueRepository? EstoqueRepository => new EstoqueRepository(_dateContext);

        public void SaveChanges()
        {
            _dateContext?.SaveChanges();
        }

        public void Dispose()
        {
            _dateContext?.Dispose();
        }
    }
}
