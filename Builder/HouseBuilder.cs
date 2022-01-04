using Nagp.DesignSession2.Models;

namespace Nagp.DesignSession2.Builder
{
    public class HouseBuilder
    {
        private readonly HouseModel _houseModel = new HouseModel();

        public void BuildWalls(string walls)
        {
            _houseModel.Walls = walls;
        }

        public void BuildDoors(string doors)
        {
            _houseModel.Doors = doors;
        }

        public void BuildWindows(string windows)
        {
            _houseModel.Windows = windows;
        }

        public void BuildRoof(string roofs)
        {
            _houseModel.Roof = roofs;
        }

        public void BuildGarage(string garage)
        {
            _houseModel.Garage = garage;
        }

        public HouseModel Build() => _houseModel;
    }
}
