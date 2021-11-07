using MediatR;
using MediatRExercise.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRExercise.Library.Queries
{
    public record GetEmployeesListQuery() : IRequest<List<EmployeeModel>>;

    //public class GetEmployeesListQueryClass : IRequest<List<EmployeeModel>>;
    //{
    //}
}
