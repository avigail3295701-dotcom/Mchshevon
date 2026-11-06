namespace Mchshevon
{
    internal class Program
    {
        public delegate double Mach(double x, double y);
        public static double chibor(double n1, double n2) { return n1 + n2; }
        public static double chisor(double n1, double n2) { return n1 - n2; }
        public static double chilok(double n1, double n2) { return n1 / n2; }
        public static double kefel(double n1, double n2) { return n1 * n2; }

        static void Main(string[] args)
        {
            Mach m =  chibor;
            double res= m(10.5,10.5);
            Console.WriteLine(res); 
          
        }
    }
}
