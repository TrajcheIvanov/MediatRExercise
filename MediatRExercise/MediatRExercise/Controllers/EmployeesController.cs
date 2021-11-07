using MediatR;
using MediatRExercise.Library.Commands;
using MediatRExercise.Library.Models;
using MediatRExercise.Library.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<EmployeeModel>> Get()
        {
            return await _mediator.Send(new GetEmployeesListQuery());
        }

        [HttpGet("{id}")]
        public async Task<EmployeeModel> Get(int id)
        {
            return await _mediator.Send(new GetEmployeeByIdQuery(id));
        }

        [HttpPost]
        public async Task<EmployeeModel> Post([FromBody] EmployeeModel employeeModel)
        {
            return await _mediator.Send(new AddEmployeeCommand(employeeModel.FirstName, employeeModel.LastName));
        }
    }
}
