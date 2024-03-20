using System;

namespace Lab05_B
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public User(string firstName, string lastName, string dateOfBirth, string emailAddress, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
            Username = username;
            Password = password;
        }
    }
}

