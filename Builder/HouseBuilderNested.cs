using Nagp.DesignSession2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagp.DesignSession2.Builder
{
    public class HouseBuilderNested: HouseModel
    {

        public class Builder : FluentHouseBuilderStrict
        {
        }

        static readonly Lazy<Builder> builder = new(() => new Builder());

        public static Builder New => builder.Value;
    }
}
