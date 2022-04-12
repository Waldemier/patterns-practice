using Composite.Implementations;

namespace PatternsPartEight
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var top = new Node("top");

			top.Nodes.Add(new Node("2nd level - 0"));
			top.Nodes.Add(new Node("2nd level - 1"));

			var lvl2_2 = new Node("2nd level - 2");
			top.Nodes.Add(lvl2_2);

			lvl2_2.Nodes.Add(new Node("3rd level - 0"));
			lvl2_2.Nodes.Add(new Node("3rd level - 1"));
			lvl2_2.Nodes.Add(new Node("3rd level - 2"));

			top.ComputeNodes();
		}
    }
}
