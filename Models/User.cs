using System.ComponentModel.DataAnnotations;

namespace Japanese_C_dang_iu.Models
{
  public class User
  {
    [Key]
    public int UserId { get; set; }

    [MaxLength(256)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(256)]
    public string Password { get; set; } = string.Empty;
  }
}