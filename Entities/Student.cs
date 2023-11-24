using System.ComponentModel.DataAnnotations;

namespace EstudoAsp.NetIdentity.Entities;

public class Student
{
    public int Id { get; set; }
    [Required, MaxLength(80)]
    public string Name { get; set; }
    [EmailAddress]
    [Required, MaxLength (120)]
    public string Email { get; set; }

    [MaxLength(80)]
    public string? Curso { get; set; }
}
