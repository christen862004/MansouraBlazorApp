namespace MansouraBlazorApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Salary { get; set; }
        public int DeptartmentID { get; set; }

        public override string ToString()
        {
            return $"Name={Name} \t Image={ImageUrl} \t Salaey={Salary} \t DepartmentId={DeptartmentID}";
        }
    }
}
