﻿using Cool.AST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool.Semantics
{
    public class TypeInfo
    {
        public string Text { get; set; } = "Object";
        public TypeInfo Parent { get; set; } = OBJECT;
        public ClassNode ClassReference { get; set; }
        public int Level { get; set; }

        public TypeInfo()
        {
        }

        public TypeInfo(string text, TypeInfo parent, ClassNode classReference)
        {
            Text = text;
            Parent = parent;
            ClassReference = classReference;
            Level = parent.Level + 1;
        }

        /// <summary>
        /// Check if a type inherit of other type in the hierarchy of the program.
        /// </summary>
        /// <param name="other">Represent the second type to check</param>
        /// <returns>True if the first type inherit of the second</returns>
        public virtual bool Inherit(TypeInfo other)
        {
            if (this == other) return true;
            return Parent.Inherit(other);
        }

        public static bool operator <=(TypeInfo a, TypeInfo b)
        {
            return a.Inherit(b);
        }

        public static bool operator >=(TypeInfo a, TypeInfo b)
        {
            return b.Inherit(a);
        }

        public static bool operator ==(TypeInfo a, TypeInfo b)
        {
            return a.Text == b.Text;
        }

        public static bool operator !=(TypeInfo a, TypeInfo b)
        {
            return !(a == b);
        }

        #region OBJECT
        private static ObjectTypeInfo objectType = new ObjectTypeInfo();

        public static ObjectTypeInfo OBJECT => objectType;

        public class ObjectTypeInfo : TypeInfo
        {

            public override bool Inherit(TypeInfo other)
            {
                return this == other;
            }
        }
        #endregion

    }
}
