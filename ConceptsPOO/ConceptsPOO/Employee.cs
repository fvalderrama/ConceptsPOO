namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HirngDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirsName} {LastName}," +
                $" Birth: {BirthDate}," +
                $" Hiring: {HirngDate}, " +
                $"Is active: {IsActive}";
        }
    }
}
