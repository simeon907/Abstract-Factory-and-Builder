namespace hw1
{
    public abstract class AbstractCar
    {
        public string Name { get;  set; }
        public string Type { get;  set; }

        public abstract override string ToString();
    }
}