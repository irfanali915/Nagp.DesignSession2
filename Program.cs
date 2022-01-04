using Nagp.DesignSession2.Bridge;
using Nagp.DesignSession2.Builder;
using System;

namespace Nagp.DesignSession2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Builder
            var builder = new HouseBuilder();
            builder.BuildDoors("2 Doors");
            builder.BuildGarage("1 Grage");
            builder.BuildRoof("1 Roof");
            builder.BuildWalls("4 Walls");
            builder.BuildWindows("2 Windows");
            var result = builder.Build();
            Console.WriteLine("Builder - {0}", result);

            //Fluent builder
            result = new FluentHouseBuilder()
                                    .BuildDoors("2 Fluent Doors")
                                    .BuildGarage("1 Grage")
                                    .BuildRoof("1 Roof")
                                    .BuildWalls("4 Walls")
                                    .BuildWindows("2 Windows")
                                    .Build();
            Console.WriteLine("\n\nFluent builder - {0}", result);

            //Strict Fluent builder
            result = new FluentHouseBuilderStrict()
                                    .BuildDoors("2 Strict Doors")
                                    .BuildWalls("4 Walls")
                                    .BuildWindows("2 Windows")
                                    .BuildGarage("1 Grage")
                                    .BuildRoof("1 Roof")
                                    .Build();
            Console.WriteLine("\n\nStrict Fluent builder - {0}", result);

            result = HouseBuilderNested.New.BuildDoors("2 Strict Doors")
                                           .BuildWalls("4 Walls")
                                           .BuildWindows("2 Windows")
                                           .BuildGarage("1 Grage")
                                           .BuildRoof("1 Roof")
                                           .Build();

            Console.WriteLine("\n\nNested builder - {0}\n\n", result);

            MessageTest.TestSend();
        }
    }
}
