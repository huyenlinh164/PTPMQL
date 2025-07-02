using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Person
{
    public String PersonId { get; set; }
    public string FullName { get; set; }
    public string Address  { get; set; }
}
