using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase3.Models
{
    public class Game
    {
        public string Gender { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Clasification Clasif { get; set; }
        public bool IsMultiplayer { get; set; }
    }
}

public enum Clasification{
    p3,
    p7,
    p12,
    p16,
    p18,
}