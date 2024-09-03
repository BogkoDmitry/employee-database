namespace EmployeeDatabase.DAL.Entities
{
    public sealed record Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
