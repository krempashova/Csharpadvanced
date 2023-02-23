using System;
using Threeuple;

namespace Threeuple
{
    public class CustomThreeuple<T1,T2,T3>
    {
        public CustomThreeuple(T1 element1,T2 element2,T3 element3)
        {
            Element1 = element1;
            Element2 = element2;
            Element3 = element3;
        }
        public T1 Element1 { get; set; }
        public T2 Element2 { get; set; }

        public T3 Element3 { get; set; }

        public override string ToString()
        {
            return $"{Element1} -> {Element2} -> {Element3}";
        }


    }
}
