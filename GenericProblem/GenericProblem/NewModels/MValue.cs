using System;
using System.Linq.Expressions;
using GenericProblem.NewModels.Interfaces;

namespace GenericProblem.NewModels
{
    public class MValue : IValue
    {
        public float Measure { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        public Expression<Func<T, TKey>> OrderByValues<T, TKey>()
        {
            return x => x.Measure;
        }
    }
}
