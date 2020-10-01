using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PizzaMario.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Addition { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

        public string Password
        {
            get => Password;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                GetPasswordHash(Password);
            }
        }

        public virtual Address Address { get; set; }
        public int AddressId { get; set; }

        public ICollection<Order> Orders { get; set; }

        public static string GetPasswordHash(string password)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = Encoding.UTF8.GetBytes(password);
                var generatedHash = sha1.ComputeHash(hash);
                var generatedHashString = Convert.ToBase64String(generatedHash);
                return generatedHashString;
            }
        }
    }
}