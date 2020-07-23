using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator
{
    public static class Rotors
    {
        public static Rotor I = new Rotor();
        public static Rotor II = new Rotor();
        public static Rotor III = new Rotor();
        public static void SetRotors()
        {
            string FileDataRaw = File.ReadAllText(@"./Rotor1Config.txt");
            I.SetRotor(FileDataRaw.Split(','));
            FileDataRaw = File.ReadAllText(@"./Rotor2Config.txt");
            II.SetRotor(FileDataRaw.Split(','));
            FileDataRaw = File.ReadAllText(@"./Rotor3Config.txt");
            III.SetRotor(FileDataRaw.Split(','));
        }
    }
}
