using System.ComponentModel.DataAnnotattions;
using System.ComponentModel.DataAnnotattions.Schema;

namespace MvcMovie.Models{
{
[Table("Persons")]
public class Person
{
    [Key]
    public string PersonId { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    
}
}