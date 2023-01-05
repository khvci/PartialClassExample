namespace PartialClassExample
{
    partial class Car
    {
        // Field

        private int speed;

        // Property
        public int Speed
        {
            get => this.speed;
            set => this.speed = value;
        }
    }
}
