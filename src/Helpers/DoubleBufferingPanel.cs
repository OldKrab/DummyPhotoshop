using System.Windows.Forms;

namespace DummyPhotoshop.Helpers
{
    public sealed class DoubleBufferingPanel:Panel
    {
        public DoubleBufferingPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}