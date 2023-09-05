namespace Domain.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int CompanyId { get; set; }
        public ICollection<Employee> Employees { get; set;}
    }
}
