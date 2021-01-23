using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroesAPI.Models
{
    public class Hero
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Ability { get; set; }
        public string SuitColor { get; set; }
        public decimal? StartingPower { get; set; }
        public decimal? CurrentPower { get; set; }
        public DateTime? dateLastTrain { get; set; }
        public short? timesTrainsToday { get; set; }
    }
}