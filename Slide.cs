using EloBuddy;
using SharpDX;

namespace Leblanc
{
    internal class Slide
    {
        public float ExpireTime { get; internal set; }
        public int NetworkId { get; internal set; }
        public GameObject Object { get; internal set; }
        public Vector3 Position { get; internal set; }
    }
}