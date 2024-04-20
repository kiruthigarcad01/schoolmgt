using System.ComponentModel.DataAnnotations;

namespace onlineschoolms.Models;

public class CourseViewModel
{
    [Key]
     public int? id { get; set; }
    public string? course { get; set; }

    public int? duration { get; set; }

     
   
}
