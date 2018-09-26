using System;

namespace CompAndDel.Filters
{
    public interface IFilterBool : IFilter
    {
        bool Boolean {get;}

        IPicture Filter(IPicture image);
    }
}