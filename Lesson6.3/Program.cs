class Company
{
    public string Type;
    public string Name;
}

class City
{
    public string Name;
}

class Department
{
    public Company Company;
    public City City;

    public Department()
    {
        Company = new Company();
        City = new City();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }
    }
    static Department GetCurrentDepartment()
    {
        Department dep = new Department();
        dep.Company.Name = "Зенит";
        dep.Company.Type = "Банк";
        dep.City.Name = "Санкт-Петербург";
        return dep;
        //Department dep = new Department { Company = { Name = "Зенит", Type = "Банк" }, City = { Name = "Санкт-Петербург" } };
        //City city = new City();
        //city.Name = "Test";        
    }
}