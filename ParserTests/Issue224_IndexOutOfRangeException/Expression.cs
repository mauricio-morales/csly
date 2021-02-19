using System.Collections.Generic;

namespace ParserTests.Issue224_IndexOutOfRangeException
{
    public abstract class Expression
    {
        public virtual bool IsRange => false;
        public abstract IEnumerable<Expression> Children { get; }
        
        public abstract string ToQuery();
    }
}