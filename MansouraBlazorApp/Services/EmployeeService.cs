namespace MansouraBlazorApp.Services
{
    public class EmployeeService : IService<Employee>
    {
        List<Employee> employees;
        public EmployeeService()
        {
            employees = new()
            {
                new(){Id=1,Name="Ali",ImageUrl="m.png",Salary=20000,DeptartmentID=1},
                new(){Id=2,Name="Sara",ImageUrl="2.jpg",Salary=20000,DeptartmentID=2},
                new(){Id=3,Name="Basma",ImageUrl="2.jpg",Salary=20000,DeptartmentID=3},
                new(){Id=4,Name="Ahmed",ImageUrl="m.png",Salary=20000,DeptartmentID=1},
                new(){Id=5,Name="abanoub",ImageUrl="m.png",Salary=20000,DeptartmentID=2}
            };
        }
        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
