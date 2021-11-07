using MediatR;
using MediatRExercise.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRExercise.Library.Commands
{
    public record AddEmployeeCommand(string firstName, string lastName) : IRequest<EmployeeModel>;

    //public class AddEmployeeCommandClass : IRequest<EmployeeModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public AddEmployeeCommandClass(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;

    //    }
    //}
}
