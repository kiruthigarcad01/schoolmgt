using System.ComponentModel.DataAnnotations;

namespace onlineschoolms.Models;

public class UserViewModel{

[Key]
 public int? id  { get; set; }
 public string? fisrtname { get; set; }

 public string? lastname { get; set; }

 public string? username { get; set; }

 public string? password { get; set; }





}