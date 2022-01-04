using Nagp.DesignSession2.Models;

namespace Nagp.DesignSession2.Builder
{
    public class FluentHouseBuilder
    {
        private readonly HouseModel _houseModel = new();

        public FluentHouseBuilder BuildWalls(string walls)
        {
            _houseModel.Walls = walls;
            return this;
        }

        public FluentHouseBuilder BuildDoors(string doors)
        {
            _houseModel.Doors = doors;
            return this;
        }

        public FluentHouseBuilder BuildWindows(string windows)
        {
            _houseModel.Windows = windows;
            return this;
        }

        public FluentHouseBuilder BuildRoof(string roofs)
        {
            _houseModel.Roof = roofs;
            return this;
        }

        public FluentHouseBuilder BuildGarage(string garage)
        {
            _houseModel.Garage = garage;
            return this;
        }

        public HouseModel Build() => _houseModel;
    }
}
