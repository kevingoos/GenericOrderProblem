using System.Collections.Generic;
using System.Linq;
using GenericProblem.NewModels.Interfaces;

namespace GenericProblem.NewModels
{
    public class GenericItemsModel<T>
        where T : IValue
    {
        public List<T> Items { get; set; }

        public void Merge(GenericItemsModel<T> collection)
        {
            if (collection != null)
            {
                Items.AddRange(collection.Items);
            }
            //This is where I use the code
            //Any approach is ok, because I now mine is not correct!
            Items = Items.OrderBy(x => x.OrderByValues<T, TKey>()).ToList();
        }
    }
}
