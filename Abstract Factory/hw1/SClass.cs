namespace hw1
{
    public class SClass:EClass
    {
        public string PersonalDriver { get;  set; }

        public SClass()
        {
            Name = "Maybach S 580";
            Type = "S-Class";
            Color = "Lightgrey";
            AirConditioner = true;
            PersonalDriver = "Steven";
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Type: {Type}\n" +
                $"Color: {Color}\n" +
                $"Air Conditioner: included\n" +
                $"Personal driver: {PersonalDriver}\n";
        }
    }
}