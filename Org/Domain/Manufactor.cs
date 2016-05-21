using System.ComponentModel.DataAnnotations;

namespace Org.Domain
{
    public class Manufactor
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}