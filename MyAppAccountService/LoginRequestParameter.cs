namespace MyAppAccountService
{
    public record LoginRequestParameter
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
