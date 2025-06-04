using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium2.Models;

[Table("Program")]
public class Program
{
    [Key]
    public int ProgramId { get; set; }
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    [Range(1, int.MaxValue)]
    public int DurationMinutes { get; set; }
    public int TemperatureCelsius { get; set; }
}