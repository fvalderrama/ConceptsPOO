using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        //Con override utilizo el metodo to string de la clase padre osea Employee
        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\tValue to pay...........: {$"{GetValueToPay():C2}", 15}";
            
        }
    }
}
