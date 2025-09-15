using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
  public class Category
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter name...")]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
  }
}
