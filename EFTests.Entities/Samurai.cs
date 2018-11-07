using System;
using System.Collections.Generic;

namespace EFTests.Entities
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();
        public List<SamuraiBattle> SamuraiBattles { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public SecretIdentity2 SecretIdentity2 { get; set; }

        public byte[] RowVersion { get; set; }
    }
}