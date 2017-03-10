<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotZon.Salotti;

namespace RobotZon
{
    class NodeWarehouse : GenericNode
    {
        public NodeWarehouse(string name) : base(name)
        {
        }

        public override bool IsEqual(GenericNode N2)
        {   
            //todo
            return true;
        }

        public override double GetArcCost(GenericNode N2)
        {
            //todo
            return 0;
        }

        public override bool EndState()
        {
            //todo
            return true;
        }

        public override List<GenericNode> GetListSucc()
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotZon.Salotti;

namespace RobotZon
{
    class NodeWarehouse : GenericNode
    {
        public NodeWarehouse(string name) : base(name)
        {
        }

        public override bool IsEqual(GenericNode N2)
        {   
            //todo
            return true;
        }

        public override double GetArcCost(GenericNode N2)
        {
            //todo
            return 0;
        }

        public override bool EndState()
        {
            //todo
            return true;
        }

        public override List<GenericNode> GetListSucc()
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
>>>>>>> 115bcbcaada5c81497dc76ce831730574fa4ba80
