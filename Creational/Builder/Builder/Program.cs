namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = Car.builder(135, 2008)
                .WithClimatronic(true)
                .WithStereo(false)
                .build();

            Car car2 = Car.builder(250, 2018)
                .build();
        }
    }
}
