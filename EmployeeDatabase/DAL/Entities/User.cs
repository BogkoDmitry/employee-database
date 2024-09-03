namespace EmployeeDatabase.DAL.Entities
{
    public record User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public DateOnly EmploymentDate { get; set; }
        public DateOnly TerminationDate { get; set; }
        public int WorkTimeType { get; set; }
        public string Email { get; set; }
        public string EmailAlias { get; set; }
        public string MobilePhone { get; set; }
        public string NameInNative { get; set; }
        public string SurnameInNative { get; set; }
        public byte[] ProfileImage { get; set; }
        public byte[] SmallProfileImage { get; set; }

    }
}
