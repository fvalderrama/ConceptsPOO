// See https://aka.ms/new-console-template for more information

using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

//Pruebas con la clase Date
//try
//{
//    Console.WriteLine(new Date(2022, 12, 7));
//    Console.WriteLine(new Date(1974, 9, 23));
//    Console.WriteLine(new Date(1985, 11, 45));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}

//Prueba con la clase SalaryEmployee
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirsName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HirngDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};
//Console.WriteLine(employee1);


//Prueba con la clase CommissionEmployee
Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirsName = "Juan",
    LastName = "Ruiz",
    BirthDate = new Date(1986, 5, 25),
    HirngDate = new Date(2021, 1, 15),
    IsActive = true,
    CommissionPercentaje = 0.10F,
    Sales = 40000000M
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirsName = "Marcos",
    LastName = "Paez",
    BirthDate = new Date(1996, 6, 24),
    HirngDate = new Date(2021, 1, 15),
    IsActive = true,
    HourValue = 16000.56M,
    Hours = 123.5F,
   
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirsName = "Julio",
    LastName = "Diaz",
    BirthDate = new Date(1997, 8, 24),
    HirngDate = new Date(2021, 1, 22),
    IsActive = true,
    Base = 1000000.56M,
    Sales = 50000000M,
    CommissionPercentaje = 0.06F,

};
//Console.WriteLine(employee4);
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                                 ===============");
Console.WriteLine($"TOTAL                            {$"{payroll:C2}",15}");


Invoice invoice1 = new Invoice()
{
    Description = "iPhome 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
}; 
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);



