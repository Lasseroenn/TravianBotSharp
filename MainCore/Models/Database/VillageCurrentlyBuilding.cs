﻿using System;

namespace MainCore.Models.Database
{
    public class VillageCurrentlyBuilding
    {
        public int Id { get; set; }
        public int VillageId { get; set; }
        public int Location { get; set; }
        public int Type { get; set; }
        public int Level { get; set; }
        public DateTime CompleteTime { get; set; }
    }
}