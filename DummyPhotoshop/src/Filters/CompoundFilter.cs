using System.Collections.Generic;
using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Фильтр-компоновщик.
    /// </summary>
    /// <remarks>
    /// Фильтры из <see cref="Filters"/> применяются последовательно.
    /// </remarks>
    public class CompoundFilter:IFilter
    {
        /// <summary>
        /// Список фильтров
        /// </summary>
        public LinkedList<IFilter> Filters { get; set; }

        public CompoundFilter()
        {
            Filters = new LinkedList<IFilter>();
        }

        public IPhoto ProcessImage(IPhoto photo)
        {
            foreach (var filter in Filters)
            {
                photo = filter.ProcessImage(photo);
            }
            return photo;
        }

    }
}