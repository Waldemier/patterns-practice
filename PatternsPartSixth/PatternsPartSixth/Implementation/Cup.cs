namespace PatternsPartSixth.Implementation
{
    public class Cup
    {
        private readonly string _label;
        private readonly CupType _type;

        public Cup(string label, CupType cupType)
        {
            _label = label;
            _type = cupType;
        }

        public void Operation()
        {
            System.Console.WriteLine($"Label: {_label} | CupType: {_type}");
        }
    }
}
