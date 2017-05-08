using System.Collections.Generic;
using System.Linq;
using GenericProblem.NewModels;

namespace GenericProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Order depending on Measure (see merge function)
            var mValues1 = new GenericItemsModel<MValue>();
            var mValues2 = new GenericItemsModel<MValue>();
            mValues1.Merge(mValues2);
            //This is the result I want to have in the merge function for the orderby:
            var list1 = new List<MValue>();
            var temp1 = list1.OrderBy(x => x.Measure);


            //Order depending on MeasureFrom and MeasureTo (see merge function)
            var xValues1 = new GenericItemsModel<XValue>();
            var xValues2 = new GenericItemsModel<XValue>();
            xValues1.Merge(xValues2);
            //This is the result I want to have in the merge function for orderby:
            var list2 = new List<XValue>();
            var temp2 = list2.OrderBy(x => x.MeasureFrom).ThenBy(y => y.MeasureTo);
        }
    }
}
