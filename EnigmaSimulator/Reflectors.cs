using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator
{
    public static class Reflectors
    {
        public static Reflector I = new Reflector();
        public static Reflector II = new Reflector();
        public static Reflector III = new Reflector();
        public static void SetReflectors()
        {
            string FileDataRaw = File.ReadAllText(@"./Reflector1Config.txt");
            I.SetReflector(FileDataRaw.Split(','));
            FileDataRaw = File.ReadAllText(@"./Reflector2Config.txt");
            II.SetReflector(FileDataRaw.Split(','));
            FileDataRaw = File.ReadAllText(@"./Reflector3Config.txt");
            III.SetReflector(FileDataRaw.Split(','));
        }


    }
}
