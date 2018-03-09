﻿using Antlr4.Runtime;
using Cool.Semantics;

namespace Cool.AST
{
    class IsVoidNode : UnaryOperationNode
    {
        public override ExpressionNode Expression => Children[0] as ExpressionNode;

        public IsVoidNode(ParserRuleContext context) : base(context)
        {
            Type = Types.Void;
        }

    }
}
