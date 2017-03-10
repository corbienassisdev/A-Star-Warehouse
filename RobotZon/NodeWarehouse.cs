using RobotZon.Salotti;
using System.Collections.Generic;

namespace RobotZon
{
    public class NodeWarehouse : Node
    {
        public NodeWarehouse(string name) : base(name)
        {
        }

        public override bool IsEqual(Node N2)
        {   
            //todo
            return true;
        }

        public override double GetArcCost(Node N2)
        {
            //todo
            return 0;
        }

        public override bool EndState()
        {
            //todo
            return true;
        }

        public override List<Node> GetListSucc()
        {
            //todo 
            return null;
        }

        public override void CalculeHCost()
        {
            //todo
        }
    }
}