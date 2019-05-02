using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ODataApp.Controllers
{

    public class EmployeeController : ODataController
    {
        [ODataRoute]
        [EnableQuery(PageSize = 5, AllowedQueryOptions = AllowedQueryOptions.All)]
        [HttpGet]
        public IQueryable<Employee> Get()
        {
            List<Employee> employees = new List<Employee>();
            List<string> hobbies = new List<string>();
            hobbies.Add("football");
            hobbies.Add("Travelling");
            employees.Add(new Employee(1,"Hatim Johar",101,"Engineer","hatimjohar@gmail.com",hobbies));
            employees.Add(new Employee(2, "Raj", 101, "Engineer", "raj@gmail.com", hobbies));
            employees.Add(new Employee(3, "John", 102, "Accounts", "john@gmail.com", hobbies));
            employees.Add(new Employee(4, "Steve", 103, "Finance", "steve@gmail.com", hobbies));
            employees.Add(new Employee(5, "Joseph", 104, "Accounts", "joseph@gmail.com", hobbies));

            employees.Add(new Employee(6, "Peter", 101, "Engineer", "peter@gmail.com", hobbies));
            employees.Add(new Employee(7, "Anthony", 101, "Engineer", "anthony@gmail.com", hobbies));
            employees.Add(new Employee(8, "Rob", 102, "Accounts", "rob@gmail.com", hobbies));
            employees.Add(new Employee(9, "Sam", 103, "Finance", "sam@gmail.com", hobbies));
            employees.Add(new Employee(10, "Rebecca", 104, "Accounts", "rebecca@gmail.com", hobbies));

            return employees.AsQueryable();
        }
    }
}