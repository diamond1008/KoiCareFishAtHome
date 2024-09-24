﻿namespace KoiCare.Domain.Entities
{
    public class Pond
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public required string Name { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Volume { get; set; }
        public decimal DrainageCount { get; set; }
        public decimal PumpCapacity { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<KoiIndividual> KoiIndividuals { get; set; } = [];
        public virtual SaltRequirement SaltRequirement { get; set; } = null!;
        public virtual ICollection<WaterParameter> WaterParameters { get; set; } = [];
    }
}