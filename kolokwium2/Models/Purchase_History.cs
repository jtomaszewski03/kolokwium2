using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Models;

[Table("Purchase_History")]
[PrimaryKey(nameof(AvailableProgramId), nameof(CustomerId))]
public class PurchaseHistory
{
    [ForeignKey("AvailableProgramId")]
    public int AvailableProgramId { get; set; }
    [ForeignKey("CustomerId")]
    public int CustomerId { get; set; }
    public DateTime PurchaseDate { get; set; }
    [Range(0, 10)]
    public int? Rating { get; set; }
    
    public virtual Customer? Customer { get; set; }
    public virtual Program? AvailableProgram { get; set; }
    
}