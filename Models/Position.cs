using System;

namespace sp_bitmexportal.Models
{
    class Position
    {
        [Jsonproperty("symbol")]
        public string Symbol { get; set; }
    }
}