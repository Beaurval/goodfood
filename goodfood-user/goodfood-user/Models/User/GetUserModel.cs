﻿using goodfood_user.Entities;

namespace goodfood_user.Models.User
{
    public class GetUserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool RegistrationValidated { get; set; }
        public int RoleId { get; set; }
    }
}
