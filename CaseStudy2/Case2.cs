using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Case2
    {

        private static int x;
        private static int y;


        private static int location = 0;
        private static int currentX = 0;
        private static int currentY = 0;


        private enum Direction
        {
            Dogu = 0,
            Bati = 1,
            Kuzey = 2,
            Guney = 3,
        }

        private static Direction direction = Direction.Dogu;

        public static void CreatArea(int width, int height)
        {
            x = width < 2 ? width = 2 : width;
            y = height > 100 ? height = 100 : height;

        }

        public static List<string> Run(string[] inputStr, int?[,] arr)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == "Robot")
                {
                    CreatArea(arr[i, 0].Value, arr[i, 1].Value);
                    result.Add(null);
                }
                else if (inputStr[i] == "step")
                {
                    step(arr[i, 0].Value);
                    result.Add(null);
                }
                else if (inputStr[i] == "getPos")
                {
                    var loc = getPos();
                    result.Add("[" + loc[0].ToString() + "," + loc[1].ToString() + "]");
                }
                else if (inputStr[i] == "getDir")
                {
                    var dir = getDir();
                    result.Add(dir);
                }
            }
            return result;
        }

        private static void step(int val)
        {
            if (val == 0) return;
            if (val > 1000) val = 1000;

            if (location == 0 && x > currentX + val)
            {
                currentX = currentX + val;
                direction = Direction.Dogu;
            }

            else if (location == 0 && x <= currentX + val)
            {
                location = 90;
                direction = Direction.Kuzey;
                currentX = currentX + 1;
                currentY = currentY + 1;
            }
            else if (location == 90 && y > currentY + val)
            {
                currentY = currentY + val;
                direction = Direction.Kuzey;
            }
            else if (location == 90 && y <= currentY + val)
            {
                location = 180;
                direction = Direction.Bati;
                currentX = currentX - val;
            }

        }


        private static int[] getPos()
        {
            return new[] { currentX, currentY };
        }

        private static string getDir()
        {
            return direction.ToString();
        }


    }
}
