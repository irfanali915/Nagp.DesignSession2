namespace Nagp.DesignSession2.Models
{
    public class HouseModel
    {
        public string Walls { get; internal set; }

        public string Doors { get; set; }

        public string Windows { get; set; }

        public string Roof { get; set; }

        public string Garage { get; set; }

        public override string ToString()
        {
            return $"Walls: {Walls},\nDoors: {Doors},\nWindows: {Windows},\nRoof: {Roof},\nGarage: {Garage}";
        }
    }
}
