namespace Core.Entities
{
    public class User : CommonEntity
    {
        public int Id { get; set; }
        public string UserGuid { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
