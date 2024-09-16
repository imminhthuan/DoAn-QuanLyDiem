using System.ComponentModel.DataAnnotations;

namespace asd123.Presenters.Major;

public class UpdateMajorRequest
{
    [Required]
    public string Code { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int DepartmentId { get; set; }
}