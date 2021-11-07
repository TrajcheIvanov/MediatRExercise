using MediatR;
using MediatRExercise.Library.Data;
using MediatRExercise.Library.Models;
using MediatRExercise.Library.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExercise.Library.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeModel>
    {
        private readonly IDataAccess _dataAccess;

        public GetEmployeeByIdHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<EmployeeModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEmployeeById(request.id));
        }
    }
}
