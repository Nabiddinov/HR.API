namespace HRDataAccess.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Departament { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public int WrongProp { get; set; }
        public Adress Adress { get; set; }
    }
}