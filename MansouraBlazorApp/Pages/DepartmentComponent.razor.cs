using MansouraBlazorApp.Models;

namespace MansouraBlazorApp.Pages
{
    public partial class DepartmentComponent
    {
        //property list<Department>
        public List<Department> DeptList { get; set; }
       
        public Department Department { get; set; }//null

        public int DeptID { get; set; }

        public DepartmentComponent()
        {
            DeptList = new List<Department>() {
                new(){Id=1,Name="SD",ManagerName="Ahmed"},
                new(){Id=2,Name="OS",ManagerName="Mohamed"},
                new(){Id=3,Name="UI",ManagerName="Sara"},
                new(){Id=4,Name="Digital Marketing",ManagerName="Esraa"},
            };
        }
        void LoadDept()
        {
            Department=DeptList.FirstOrDefault(d => d.Id == DeptID);
        }

    }
}
