using HomeTaskMethodMethodoverload.MinValue;

namespace HomeTaskMethodMethodoverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = new int[] { 1,2,3,4,5,6,7,8,9};
            Class1.MinValue(newArr);

        }
        public static int Area(int r)
        {
            return 3 * r * r;
        }
        public static int Area(int a, int b)
        {
            return a * b;
        }
        public static int Area(int a, int b, int c)
        {

            return 2 * (a * b + b * c + c * b);
        }
        public static int Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            int S = p * r;
            return S;
        }
    }
}
