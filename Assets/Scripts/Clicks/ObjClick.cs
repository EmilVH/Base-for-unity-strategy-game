using InGameObjects.Units;

namespace Clicks
{
    public class ObjClick : Click
    {
        public ObjClick()
        {
            Type = "object_click";
        }

        public Unit From;
        public int MaxDist;
    }
}