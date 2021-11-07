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
    public class GetEmployeesListHandler : IRequestHandler<GetEmployeesListQuery, List<EmployeeModel>>
    {
        private readonly IDataAccess _dataAccess;

        public GetEmployeesListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<EmployeeModel>> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEmployees());
        }
    }
}
