using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System;
namespace MvcProject.Models;
public class Movie
{
    public int Id { get; set; }
    public String? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate  { get; set; }
    public string? genre{ get; set; }
    public decimal price{ get; set; }
}