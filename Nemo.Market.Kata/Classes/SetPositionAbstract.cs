using System.Drawing;

namespace Nemo.Market.Kata.Classes
{
    public abstract class SetPositionAbstract
    {

        public Point Position { get; private set; }


        public void SetPosition(Point point)
        {
          this.Position = point;
        }
    }
}