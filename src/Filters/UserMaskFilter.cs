namespace DummyPhotoshop.Filters
{
    public class UserMaskFilter:MaskFilter
    {
        public double[,] Mask { get; set; }

        protected override void InitMask()
        {
            _mask = Mask;
            Radius = Mask.GetLength(0) / 2;
        }
    }
}