
namespace hw1
{
    public class EClass : AClass
    {
        public bool AirConditioner { get;  set; }

        public EClass()
        {
            Name = "AMG E 53";
            Type = "E-Class";
            Color = "Lightgrey";
            AirConditioner = true;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Type: {Type}\n" +
                $"Color: {Color}\n" +
                $"Air Conditioner: included\n";
        }
    }
}
