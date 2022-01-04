using Nagp.DesignSession2.Models;

namespace Nagp.DesignSession2.Builder
{
    public class FluentHouseBuilderStrict
    {
        protected readonly HouseModel _houseModel;

        public FluentHouseBuilderStrict() => _houseModel = new();
        public FluentHouseBuilderStrict(HouseModel houseModel) => _houseModel = houseModel;

        public FluentHouseBuilderStrict BuildWalls(string walls)
        {
            _houseModel.Walls = walls;
            return this;
        }

        public FluentHouseBuilderStrict BuildDoors(string doors)
        {
            _houseModel.Doors = doors;
            return this;
        }

        public FluentHouseBuilderStrictFinal BuildWindows(string windows)
        {
            _houseModel.Windows = windows;
            return new FluentHouseBuilderStrictFinal(_houseModel);
        }

        public FluentHouseBuilderStrictFinal BuildRoof(string roofs)
        {
            _houseModel.Roof = roofs;
            return new FluentHouseBuilderStrictFinal(_houseModel);
        }

        public FluentHouseBuilderStrict BuildGarage(string garage)
        {
            _houseModel.Garage = garage;
            return this;
        }
    }

    public class FluentHouseBuilderStrictFinal : FluentHouseBuilderStrict
    {
        public FluentHouseBuilderStrictFinal(HouseModel houseModel) : base(houseModel)
        {

        }

        public HouseModel Build() => _houseModel;
    }
}
