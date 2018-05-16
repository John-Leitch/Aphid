﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Components.Aphid.Parser
{
    public class AphidExpressionBinder : SerializationBinder
    {
        private const string _prefix = "System.Collections.Generic.List`1[[";

        public override Type BindToType(string assemblyName, string typeName)
        {
            if (typeName.StartsWith(_prefix))
            {
                var name = typeName.Substring(_prefix.Length).RemoveAtIndexOf(',');
                var t = typeof(List<>).MakeGenericType(Type.GetType(name));

                return t;
            }
            else
            {
                var t = Type.GetType(typeName);

                return t;
            }
        }
    }
}