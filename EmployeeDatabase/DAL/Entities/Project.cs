namespace EmployeeDatabase.DAL.Entities
{
    public sealed record Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectStatusId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int ResponsibleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
