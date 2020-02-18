using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bolt.Model
{
    [Table("Arucikkek")]
    public class Aru
    {
        public Guid Id { get; set; }

        public string Nev { get; set; }

        public long Darabszam { get; set; }

        public long Vonalkod { get; set; }
    }
}
