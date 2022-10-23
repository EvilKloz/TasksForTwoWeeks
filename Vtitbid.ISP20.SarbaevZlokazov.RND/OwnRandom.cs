using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.RND
{
    public static class OwnRandom
    {
        static public int Next(int first, int second)
        {
            Thread.Sleep(120);
            double seconds = DateTime.Now.Second;
            int milliseconds = DateTime.Now.Millisecond;
            int dop = Convert.ToString(second).Length;
            int random = Convert.ToInt32(Math.Pow(seconds, 3)) * milliseconds / 3* (dop*10);
            int result = 0;
            int show = second - first + 1;
            int[] choices = new int[show];
            choices[0] = first;
            for (int i = 1; i < choices.Length; i++)
            {
                choices[i] = choices[i - 1] + 1;
            }
            int g = 0;
            for (int i = 1; i < random; i++)
            {

                if (g < show)
                {

                    result = choices[g];
                    g += 1;
                }
                else
                {
                    g = 0;
                }

            }
            return result;
        }
    }
}
