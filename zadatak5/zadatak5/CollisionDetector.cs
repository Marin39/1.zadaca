using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak5 {
    public class CollisionDetector {
        public static int x = 0;

        public static bool Overlaps(Sprite s1, Sprite s2) {

            Rectangle r1 = new Rectangle(x: (int)Math.Round(s1.Position.X),
                                         y: (int)Math.Round(s1.Position.Y),
                                         height: s1.Size.Height,
                                         width: s1.Size.Width);

            Rectangle r2 = new Rectangle(x: (int)Math.Round(s2.Position.X),
                                         y: (int)Math.Round(s2.Position.Y),
                                         height: s2.Size.Height,
                                         width: s2.Size.Width);
          

            return r1.Intersects(r2);
        }
    }
}
