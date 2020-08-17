using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GitChallenge.Domain.Specification
{
    public abstract class TransformSpecification<TSource, TTarget>
    {
        protected abstract Expression<Func<TSource, TTarget>> SpecificationExpression { get; }

        public static implicit operator Expression<Func<TSource, TTarget>>(TransformSpecification<TSource, TTarget> spec) => spec.SpecificationExpression;
    }
}
