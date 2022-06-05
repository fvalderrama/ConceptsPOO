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
//Employee employee1 = new SalaryEmployee()
//{
//    Id = 1010,
//    FirsName = "Sandra",
//    LastName = "Morales",
//    BirthDate = new Date(1990, 5, 23),
//    HirngDate = new Date(2022, 1, 15),
//    IsActive = true,
//    Salary = 1815453.45M
//};

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
Console.WriteLine(employee2);


