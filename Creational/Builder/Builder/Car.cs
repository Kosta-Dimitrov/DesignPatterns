namespace Builder
{
    public class Car
    {
        //required params
        private int horsePower { get; set; }
        private int year { get; set; }

        //optional params
        private bool hasStereo { get; set; }
        private bool hasClimatronic { get; set; }

        public static CarBuilder builder(int horsePower, int year)
        {
            return new CarBuilder(horsePower, year);
        }

        private Car(CarBuilder carBuilder)
        {
            this.year = carBuilder.GetYear();
            this.horsePower = carBuilder.GetHorsePower();
            this.hasClimatronic = carBuilder.HasClimatronic();
            this.hasStereo = carBuilder.HasStereo();
        }

        public class CarBuilder
        {
            private int horsePower { get; set; }
            private int year { get; set; }
            private bool hasStereo { get; set; }
            private bool hasClimatronic { get; set; }

            public int GetHorsePower()
                => this.horsePower;

            public int GetYear()
                => this.year;

            public bool HasStereo()
                => this.hasStereo;

            public bool HasClimatronic()
                => this.hasClimatronic;

            public CarBuilder(int horsePower, int year)
            {
                this.horsePower = horsePower;
                this.year = year;
            }

            public CarBuilder WithStereo(bool hasStereo)
            {
                this.hasStereo = hasStereo;
                return this;
            }

            public CarBuilder WithClimatronic(bool hasClimatronic)
            {
                this.hasClimatronic = hasClimatronic;
                return this;
            }

            public Car build()
            {
                return new Car(this);
            }
        }
    }
}
