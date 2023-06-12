using AutoMapper;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Profiles
{
    public class CommandToModelProfile : Profile
    {
        public CommandToModelProfile()
        {
            #region Create
            CreateMap<EstoqueCreateCommand, Estoque>().AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });

            CreateMap<ProdutoCreateCommand, Produto>().AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });
            #endregion

            //#region Update
            //CreateMap<EstoqueUpdateCommand, Estoque>().AfterMap((command, model) =>
            //{
            //    model.Id = Guid.NewGuid();
            //});

            //CreateMap<ProdutoUpdateCommand, Produto>().AfterMap((command, model) =>
            //{
            //    model.Id = Guid.NewGuid();
            //});
            //#endregion

            //#region Delete
            //CreateMap<EstoqueDeleteCommand, Estoque>().AfterMap((command, model) =>
            //{
            //    model.Id = Guid.NewGuid();
            //});

            //CreateMap<ProdutoDeleteCommand, Produto>().AfterMap((command, model) =>
            //{
            //    model.Id = Guid.NewGuid();
            //});
            //#endregion
        }
    }
}
