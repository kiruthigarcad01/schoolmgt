using System.ComponentModel.DataAnnotations;

namespace onlineschoolms.Models;

public class RegistrationViewModel{


 public string? fisrtname { get; set; }

 public string? lastname { get; set; }

 public string? nic { get; set; }

 public int? course_id { get; set; }

  public int? batch_id { get; set; }

  public int? telno { get; set; }

}