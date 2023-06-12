using EstoqueApp.Application.Interfaces.Persistences;
using EstoqueApp.Application.Interfaces.Services;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Services
{
    public class ProdutoAppService : IProdutoAppServices
    {
        private readonly IMediator _mediator;
        private readonly IProdutoPersistence _produtoPersistence;

        public ProdutoAppService(IProdutoPersistence produtoPersistence, IMediator mediator)
        {
            _produtoPersistence = produtoPersistence;
            _mediator = mediator;
        }

        public async Task<ProdutoQuery> Create(ProdutoCreateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ProdutoQuery> Delete(ProdutoDeleteCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ProdutoQuery> Update(ProdutoUpdateCommand command)
        {
            return await _mediator.Send(command);
        }

        public List<ProdutoQuery> GetAll()
        {
            return _produtoPersistence.GetAll();
        }

        public ProdutoQuery GetById(Guid? id)
        {
            return _produtoPersistence.GetById(id.Value);
        }
    }
}
