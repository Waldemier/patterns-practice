using System.Collections.Generic;

namespace Composite.Implementations
{
	public class Node
	{
		public string NodeData { get; set; }
		public List<Node> Nodes { get; set; } = new List<Node>();

		public Node(string data)
		{
			this.NodeData = data;
		}

		public void ComputeNodes()
		{
            System.Console.WriteLine(NodeData);

			foreach (var n in Nodes)
			{
				n.ComputeNodes();
			}
		}
	}
}
