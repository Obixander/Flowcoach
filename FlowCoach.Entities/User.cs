namespace FlowCoach.Entities
{
    public class User
    {

        private int userId;
        private string fullName;
        private string email;
        private string password;
        private List<JournalEntry> journalEntries;

        public int UserId 
        {
            get => userId;
            set 
            {
                if (value >= 0)
                {
                    if (value != userId)
                    userId = value;
                }
                else
                {
                    throw new Exception("Id must be a positive number");
                }
            }
        }
        public string FullName 
        { 
            get => fullName;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != fullName)
                        fullName = value;
                }
                else
                {
                    throw new Exception("Full name must not be empty");
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (value.Contains('@') && value.Contains('.') && value.Length > 2)
                {
                    if (value != email)
                    email = value;
                }
                else
                    throw new System.Exception("Invalid email address, an email must contain a @ and . ");
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value != password)
                        password = value;
                }
                else
                {
                    throw new Exception("Password must not be empty");
                }
            }
        }
        public List<JournalEntry> JournalEntries 
        {
            get => journalEntries;
            set 
            {
                if (value != null)
                {
                    if (value != journalEntries)
                        journalEntries = value;
                }
                else
                {
                    throw new Exception("Value was null");
                }
            } 
        }
    }
}
