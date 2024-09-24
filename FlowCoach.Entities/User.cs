namespace FlowCoach.Entities
{
    public class User
    {

        private int userId;
        private string fullName;
        private string email;
        private string password;
        private List<JournalEntry> journalEntries;

        public int UserId { get => userId; set => userId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email
        { 
            get => email;
            set
            {
                if (value.Contains("@") && value.Contains(".") && value.Length > 2) email = value;
                else throw new System.Exception("Invalid email address");
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Contains(" ")) throw new System.Exception("Invalid password");
                else password = value;
            }
        }
        public List<JournalEntry> JournalEntries { get => journalEntries; set => journalEntries = value; }
    }
}
