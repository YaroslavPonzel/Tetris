using System;

namespace TetrisLib
{
    public class RGBColor
    {
        public byte RedNumber { get; private set; }
        public byte GreenNumber { get; private set; }
        public byte BlueNumber { get; private set; }

        public RGBColor(byte redNumber, byte greenNumber, byte blueNumber)
        {
            RedNumber = redNumber;
            GreenNumber = greenNumber;
            BlueNumber = blueNumber;
        }

        public byte[] GetRGBNumbers() => new byte[3] { RedNumber, GreenNumber, BlueNumber };

        public static bool operator ==(RGBColor color1, RGBColor color2) 
            => (color1.RedNumber == color2.RedNumber && color1.BlueNumber == color2.BlueNumber && color1.GreenNumber == color2.GreenNumber);

        public static bool operator !=(RGBColor color1, RGBColor color2) => !(color1 == color2);

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;

            RGBColor c = (RGBColor)obj;
            return RedNumber == c.RedNumber && BlueNumber == c.BlueNumber && GreenNumber == c.GreenNumber;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
