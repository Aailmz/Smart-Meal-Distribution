namespace LKS2026.Helpers
{
    /// <summary>Menyimpan informasi pengguna yang sedang login.</summary>
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; }
        public static string Position { get; set; }

        public static bool IsPetugas => Role == "PetugasSPPG";
        public static bool IsSupervisor => Role == "SupervisorSPPG";

        public static void Set(int userId, string username, string fullName, string role, string position)
        {
            UserId = userId;
            Username = username;
            FullName = fullName;
            Role = role;
            Position = position;
        }

        public static void Clear()
        {
            UserId = 0;
            Username = FullName = Role = Position = null;
        }
    }
}
