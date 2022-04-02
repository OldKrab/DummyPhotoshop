using DummyPhotoshop.Data;

namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Интерфейс фильтра для изображений
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Применить к изображению фильтр
        /// </summary>
        /// <param name="photo">Обрабатываемое изображение</param>
        /// <returns>Результирующее изображение</returns>
        public IPhoto ProcessImage(IPhoto photo);
    }
}