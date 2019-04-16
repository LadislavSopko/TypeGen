using System;

namespace TypeGen.Core.SpecGeneration.Generic
{
    /// <summary>
    /// Builds the class configuration section inside generation spec
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ClassSpecBuilder<T> : CommonClassSpecBuilder<T, ClassSpecBuilder<T>>
    {
        internal ClassSpecBuilder(TypeSpec spec) : base(spec)
        {
        }
    }
}