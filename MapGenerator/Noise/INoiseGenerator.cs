using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.Noise
{
    interface INoiseGenerator
    {
        public double GenerateNoise();

        public double[] Generate1DNoiseMap();

        public double[,] Generate2DNoiseMap();

        public double[,,] Generate3DNoiseMap();
    }
}
