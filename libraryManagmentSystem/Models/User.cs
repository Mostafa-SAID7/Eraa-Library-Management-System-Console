namespace AdvancedLibraryManagementSystem.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }  // WARNING: Plaintext passwords (for demo only)
        public bool IsAdmin { get; set; }
    }
}
