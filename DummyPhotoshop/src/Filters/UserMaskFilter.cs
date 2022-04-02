namespace DummyPhotoshop.Filters
{
    /// <summary>
    /// Фильтр, который применяет маску <see cref="Mask"/> к каждому пикселю изображения.
    /// </summary>
    public class UserMaskFilter:MaskFilter
    {
        /// <summary>
        /// Маска, которая применяется к каждому пикселю.
        /// </summary>
        public new double[,] Mask { get; set; }


        protected override void InitMask()
        {
            base.Mask = Mask;
            Radius = Mask.GetLength(0) / 2;
        }
    }
}