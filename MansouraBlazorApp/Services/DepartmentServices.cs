namespace MansouraBlazorApp.Services
{
    public class DepartmentServices : IService<Department>
    {
        List<Department> departmentList;
        public DepartmentServices()
        {
            departmentList = new List<Department>() {
                new(){Id=1,Name="SD",ManagerName="Ahmed"},
                new(){Id=1,Name="OS",ManagerName="Esraa"},
                new(){Id=1,Name="UI",ManagerName="Abdallah"},
            };
        }

        public List<Department> GetAll()
        {
            return departmentList;
        }

        public Department GetById(int id)
        {
            return departmentList.FirstOrDefault(d => d.Id == id);
        }
    }
}
