namespace PraktykiLipiec2023.Data.Entities;

public class ProductEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Prize { get; set; }
    public float Amount { get; set; }
    public bool HasPlaceOnMarket { get; set; }
}