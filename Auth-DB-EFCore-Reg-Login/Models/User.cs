﻿using System.Text.Json.Serialization;

namespace Auth_DB_EFCore_Reg_Login.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
