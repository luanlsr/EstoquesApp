using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProdutoRepository? ProdutoRepository { get; }
        IEstoqueRepository? EstoqueRepository { get; }
        void SaveChanges();
    }
}
