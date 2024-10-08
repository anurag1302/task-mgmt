﻿namespace TasksMgmt.Core.Entities
{
    public class User: BaseEntity
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
