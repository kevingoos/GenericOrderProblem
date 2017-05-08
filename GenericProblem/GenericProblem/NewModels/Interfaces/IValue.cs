using System;
using System.Linq.Expressions;

namespace GenericProblem.NewModels.Interfaces
{
    public interface IValue
    {
        Expression<Func<T, TKey>> OrderByValues<T, TKey>();
    }
}
