using DummyPhotoshop.Data;
using Photoshop.Data;

namespace Photoshop.Filters
{
    public interface IFilter
    {
        public Photo ProcessImage(Photo photo);
    }
}