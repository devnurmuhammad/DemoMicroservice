using System.ComponentModel.DataAnnotations.Schema;

namespace BuildingMaterials.Domain.Entities;

public class Purchase
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int MaterialId { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    [ForeignKey(nameof(MaterialId))]
    public Material Materials { get; set; }
    [ForeignKey(nameof(ClientId))]
    public Client Clients { get; set; }
}
