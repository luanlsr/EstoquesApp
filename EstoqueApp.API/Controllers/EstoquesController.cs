using EstoqueApp.Application.Interfaces.Services;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoquesController : ControllerBase
    {
        private readonly IEstoqueAppServices _estoqueAppServices;

        public EstoquesController(IEstoqueAppServices estoqueAppServices)
        {
            _estoqueAppServices = estoqueAppServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof (EstoqueQuery), 201)]
        public async Task<IActionResult> Post(EstoqueCreateCommand command)
        {
            return StatusCode(201, await _estoqueAppServices?.Create(command));
        }

        [HttpPut]
        [ProducesResponseType(typeof(EstoqueQuery), 200)]
        public async Task<IActionResult> Put(EstoqueUpdateCommand command)
        {
            return StatusCode(200, await _estoqueAppServices?.Update(command));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(EstoqueQuery), 200)]
        public async Task<IActionResult> Delete(Guid? id)
        {
            var command = new EstoqueDeleteCommand { Id = id };
            return StatusCode(200, await _estoqueAppServices?.Delete(command));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<EstoqueQuery>), 200)]
        public IActionResult GetAll() 
        {
            return StatusCode(200, _estoqueAppServices?.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EstoqueQuery), 200)]
        public IActionResult GetById(Guid? id) 
        {
            return StatusCode(200, _estoqueAppServices?.GetById(id));
        }
    }
}
