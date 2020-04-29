using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Railway.Models.Interfaces;

namespace Railway.Models.Entities
{
    public class User : ICommonEntity
    {
        [Key] public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUpdated { get; set; }

        public string Username { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<LoginHistory> Logins { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Username}/{Email}";
        }
    }
}
