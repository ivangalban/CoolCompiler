﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AST.Scope;

namespace AST.Visitor
{
    interface IVisit
    {
        void Accept(IVisitor visitor, IScope scope);
    }
}
