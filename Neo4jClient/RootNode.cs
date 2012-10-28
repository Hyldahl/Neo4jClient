﻿using Neo4jClient.Cypher;

namespace Neo4jClient
{
    public class RootNode : NodeReference<RootNode>
    {
        public RootNode() : base(0) { }
        public RootNode(long id) : base(id) {}
        public RootNode(long id, IGraphClient client) : base(id, client) {}

        public ICypherFluentQueryStarted StartCypher(string identity)
        {
            var client = ((IAttachedReference)this).Client;
            var query = new CypherFluentQuery(client)
                .AddStartPoint(identity, this);
            return query;
        }
    }
}
