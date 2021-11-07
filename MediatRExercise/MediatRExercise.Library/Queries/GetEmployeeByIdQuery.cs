using MediatR;
using MediatRExercise.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRExercise.Library.Queries
{
    public record GetEmployeeByIdQuery(int id) : IRequest<EmployeeModel>;

    //public class GetEmployeeByIdQueryClass : IRequest<EmployeeModel>
    //{
    //    public int Id { get; set; }

    //    public GetEmployeeByIdQueryClass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
 