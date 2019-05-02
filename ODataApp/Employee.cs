using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataApp
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public int department_id { get; set; }
        public string department_name { get; set; }
        public string email { get; set; }
        public List<string> hobbies { get; set; }

        public Employee(int _employee_id, string _employee_name, int _dept_id,
                        string _dept_name, string _email, List<string> _hobbies)
        {
            employee_id = _employee_id;
            employee_name = _employee_name;
            department_id = _dept_id;
            department_name = _dept_name;
            email = _email;
            hobbies = _hobbies;
        }
    }

}
