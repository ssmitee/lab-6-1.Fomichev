namespace SphereChargeAndPotential
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаметр первого шара (в метрах):");
            double r1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите диаметр второго шара (в метрах):");
            double r2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите диаметр третьего шара (в метрах):");
            double r3 = double.Parse(Console.ReadLine());

            double electricFieldStrength = 3e6; // Напряженность поля (в В/м)

            double q1 = CalculateMaxCharge(r1, electricFieldStrength);
            double q2 = CalculateMaxCharge(r2, electricFieldStrength);
            double q3 = CalculateMaxCharge(r3, electricFieldStrength);

            double v1 = CalculateMaxPotential(q1, r1);
            double v2 = CalculateMaxPotential(q2, r2);
            double v3 = CalculateMaxPotential(q3, r3);

            Console.WriteLine("Максимальный предельный заряд для первого шара: " + q1 + " Кл");
            Console.WriteLine("Максимальный предельный заряд для второго шара: " + q2 + " Кл");
            Console.WriteLine("Максимальный предельный заряд для третьего шара: " + q3 + " Кл");

            Console.WriteLine("Максимальный потенциал для первого шара: " + v1 + " В");
            Console.WriteLine("Максимальный потенциал для второго шара: " + v2 + " В");
            Console.WriteLine("Максимальный потенциал для третьего шара: " + v3 + " В");
        }

        static double CalculateMaxCharge(double radius, double electricFieldStrength)
        {
            double epsilon0 = 8.8541878128e-12; // Электрическая постоянная (в Ф/м)
            return 4 * Math.PI * epsilon0 * radius * radius * electricFieldStrength;
        }

        static double CalculateMaxPotential(double charge, double radius)
        {
            double epsilon0 = 8.8541878128e-12; // Электрическая постоянная (в Ф/м)
            return 1 / (4 * Math.PI * epsilon0) * charge / radius;
        }
    }
}