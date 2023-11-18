﻿namespace BuildingMaterials.Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public ICollection<Material> Materials { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
}