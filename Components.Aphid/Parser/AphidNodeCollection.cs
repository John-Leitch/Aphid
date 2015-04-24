using System;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public abstract class AphidNodeCollection<TNodeType> : AphidNode
        where TNodeType : AphidNode
    {
        private List<TNodeType> _nodes = new List<TNodeType>();

        public List<TNodeType> Nodes
        {
            get { return _nodes; }
            set { _nodes = value; }
        }
    }
}

