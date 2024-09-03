namespace EmployeeDatabase.DAL.Entities
{
    public sealed record Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HeadId { get; set; }
        public string NameInNative { get; set; }
        public string AbbreviatedName { get; set; }
    }
}
