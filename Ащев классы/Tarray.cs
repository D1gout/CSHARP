using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ащев
{
    class Tarray
    {
        int[] m;
        int size;
        int rMin;
        int rMax;
        string text = "";

        public Tarray()
        {
            size = 15;
            rMin = 0;
            rMax = 100;
            FillArray();
            text =  $"Объект создаётся конструктором по умолчанию, размер массива = {size}, диапозон рандома от {rMin} до {rMax}";
        }

        public Tarray(int n, int rS, int rB)
        {
            size = n;
            rMin = rS;
            rMax = rB;
            FillArray();
            text = $"Объект создаётся конструктором с двумя параметрами, размер массива = {size}, диапозон рандома от {rMin} до {rMax}";
        }

        void FillArray()
        {
            Random Rand = new Random();
            m = new int[size];
            for (int i = 0; i < size; i++)
                m[i] = Rand.Next(rMin, rMax);
        }

        public string GetStringArray()
        {

            var str = new StringBuilder();
            for (int i = 0; i < m.Length; i++)
                str.Append(m[i] + " ");
            return $"\n{text}\n" + "Массив чисел:\n" + str.ToString();
        }

        public int LowNumber()
        {
            var L = rMax;
            for (int i = 0; i < size; i++)
            {
                if (L > m[i])
                    L = m[i];
            }
            return L;
        }
        public double SrNumber()
        {
            var k = 0;
            double SrNum = 0;
            for (int i = 0; i < size; i++)
            {
                SrNum += m[i];
                k++;
            }

            SrNum /= k;
            SrNum = Math.Round(SrNum, 2);
            return SrNum;
        }
    }
}

