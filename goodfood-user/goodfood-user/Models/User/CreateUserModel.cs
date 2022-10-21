﻿namespace goodfood_user.Models.User
{
    public class CreateUserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string Uuid { get; set; }
        public string PhoneNumber { get; set; }
    }
}
