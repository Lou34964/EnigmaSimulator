﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSimulator
{
    public class Rotor
    {
        public char PointToFlip = 'Z';
        public int RotorPosittion = 0;
        #region A-Z
        public char A { get; set; }
        public char B { get; set; }
        public char C { get; set; }
        public char D { get; set; }
        public char E { get; set; }
        public char F { get; set; }
        public char G { get; set; }
        public char H { get; set; }
        public char I { get; set; }
        public char J { get; set; }
        public char K { get; set; }
        public char L { get; set; }
        public char M { get; set; }
        public char N { get; set; }
        public char O { get; set; }
        public char P { get; set; }
        public char Q { get; set; }
        public char R { get; set; }
        public char S { get; set; }
        public char T { get; set; }
        public char U { get; set; }
        public char V { get; set; }
        public char W { get; set; }
        public char X { get; set; }
        public char Y { get; set; }
        public char Z { get; set; }
        #endregion

        public void SetRotor(string[] setting)
        {
            this.A = char.Parse(setting[0]);
            this.B = char.Parse(setting[1]);
            this.C = char.Parse(setting[2]);
            this.D = char.Parse(setting[3]);
            this.E = char.Parse(setting[4]);
            this.F = char.Parse(setting[5]);
            this.G = char.Parse(setting[6]);
            this.H = char.Parse(setting[7]);
            this.I = char.Parse(setting[8]);
            this.J = char.Parse(setting[9]);
            this.K = char.Parse(setting[10]);
            this.L = char.Parse(setting[11]);
            this.M = char.Parse(setting[12]);
            this.N = char.Parse(setting[13]);
            this.O = char.Parse(setting[14]);
            this.P = char.Parse(setting[15]);
            this.Q = char.Parse(setting[16]);
            this.R = char.Parse(setting[17]);
            this.S = char.Parse(setting[18]);
            this.T = char.Parse(setting[19]);
            this.U = char.Parse(setting[20]);
            this.V = char.Parse(setting[21]);
            this.W = char.Parse(setting[22]);
            this.X = char.Parse(setting[23]);
            this.Y = char.Parse(setting[24]);
            this.Z = char.Parse(setting[25]);
        }

        public char GetIncr(char c)
        {
            switch (c)
            {
                case 'A':
                    return A;
                case 'B':
                    return B;
                case 'C':
                    return C;
                case 'D':
                    return D;
                case 'E':
                    return E;
                case 'F':
                    return F;
                case 'G':
                    return G;
                case 'H':
                    return H;
                case 'I':
                    return I;
                case 'J':
                    return J;
                case 'K':
                    return K;
                case 'L':
                    return L;
                case 'M':
                    return M;
                case 'N':
                    return N;
                case 'O':
                    return O;
                case 'P':
                    return P;
                case 'Q':
                    return Q;
                case 'R':
                    return R;
                case 'S':
                    return S;
                case 'T':
                    return T;
                case 'U':
                    return U;
                case 'V':
                    return V;
                case 'W':
                    return W;
                case 'X':
                    return X;
                case 'Y':
                    return Y;
                case 'Z':
                    return Z;
                default:
                    return '$';
            }
        }

        public void Rotate(int Times)
        {
            for (int _ = 0; _ < Times; _++)
            {
                char temp = A;
                A = B;
                B = C;
                C = D;
                D = E;
                E = F;
                F = G;
                G = H;
                H = I;
                I = J;
                J = K;
                K = L;
                L = M;
                M = N;
                N = O;
                O = P;
                P = Q;
                Q = R;
                R = S;
                S = T;
                T = U;
                U = V;
                V = W;
                W = X;
                X = Y;
                Y = Z;
                Z = temp;
            }
        }

        public string GetCurrentConfig()
        {
            string ret = $"{A}, ";
            char[] AZ = {  B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y };
            foreach (char c in AZ)
            {
                ret += $"{c}, ";
            }
            ret += Z;
            return ret;
        }
    }
}
