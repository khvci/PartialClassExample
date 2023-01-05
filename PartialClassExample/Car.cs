namespace PartialClassExample
{
    partial class Car
    {
        //Fields

        private readonly string make;
        private readonly string model;
        private readonly int productionYear;

        //Properties

        public string Make
        {
            get => this.make;
        }

        public string Model
        {
            get => this.model;
        }

        public int ProductionYear
        {
            get => this.productionYear;
        }

        // Constructor

        public Car(string make, string model, int productionYear)
        {
            this.make = make;
            this.model = model;
            this.productionYear = productionYear;
        }
    }
}
