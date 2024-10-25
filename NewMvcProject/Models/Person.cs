using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewMvcProject.Models;
[Table("Person")]
public class Person
{
    [Key]
    public String PersonId { get; set; }
    public string? fullName { get; set; }
    public string? Adress { get; set; }

}