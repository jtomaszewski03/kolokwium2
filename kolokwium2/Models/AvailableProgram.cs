using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium2.Models;

[Table("Available_Program")]
public class AvailableProgram
{
    [Key]
    public int AvailableProgramId { get; set; }
    [ForeignKey("WashingMachineId")]
    public int WashingMachineId { get; set; }
    [ForeignKey("ProgramId")]
    public int ProgramId { get; set; }
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }
    
    
    public Program Program { get; set; } = null!;
    public WashingMachine WashingMachine { get; set; } = null!;
    
}