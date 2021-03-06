using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Фильтр тиснения
    /// </summary>
    public class EmbossingFilter : IFilter
    {
        private CompoundFilter _filter;
        public EmbossingFilter()
        {
            _filter = new CompoundFilter();
            var maskFilter = new UserMaskFilter
            {
                Mask = new double[,]
                {
                    {0.0, 1.0, 0.0},
                    {1.0, 0.0,-1.0},
                    {0.0,-1.0, 0.0}
                }
            };
            var brightFilter = new BrightnessFilter();
            brightFilter.Coefficient = 128;
            _filter.Filters.AddLast(maskFilter);
            _filter.Filters.AddLast(brightFilter);
        }

        /// <inheritdoc/>
        public IPhoto ProcessImage(IPhoto photo)
        {
            return _filter.ProcessImage(photo);
        }
    }
}