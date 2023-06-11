
using System.Runtime.Remoting.Messaging;

namespace hw1
{
    public class AClass : AbstractCar
    {
     
        public string Color { get; set; }
        public AClass() 
        {
            Name = "A 45 AMG";
            Type = "A-Class";
            Color = "grey";
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Type: {Type}\n" +
                $"Color: {Color}\n";
        }
    }
}
