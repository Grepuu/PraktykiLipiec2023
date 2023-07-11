using PraktykiLipiec2023.Data.Enums;

namespace PraktykiLipiec2023.Data.Entities;

public class MarketLaneShelfEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public MarketLaneShelfLevelEnum Level { get; set; }
}