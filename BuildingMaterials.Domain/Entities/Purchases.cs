namespace BuildingMaterials.Domain.Entities;

public class Purchases
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int MaterialId { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    
    //public Materials Material { get; set; }
}
