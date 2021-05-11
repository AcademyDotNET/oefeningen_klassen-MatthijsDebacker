using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapGenerator.Noise;

namespace MapGenerator.Maps
{
    interface IMapGenerator
    {
        public void Generate1DMap(INoiseGenerator noiseGenerator);
        public void Generate2DMap(INoiseGenerator noiseGenerator);
        public void Generate3DMap(INoiseGenerator noiseGenerator);
    }
}
