namespace OneToMeny.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
