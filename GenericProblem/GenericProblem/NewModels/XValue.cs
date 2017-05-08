using System;
using System.Linq.Expressions;
using GenericProblem.NewModels.Interfaces;

namespace GenericProblem.NewModels
{
    public class XValue : IValue
    {
        public float MeasureFrom { get; set; }
        public float MeasureTo { get; set; }
        public string Name { get; set; }
        
        public Expression<Func<T, TKey>> OrderByValues<T, TKey>()
        {
            return x => x.MeasureFrom, x.MeasureTo;
        }
    }
}
