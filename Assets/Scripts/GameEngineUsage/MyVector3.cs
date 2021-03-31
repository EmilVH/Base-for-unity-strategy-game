using UnityEngine;

namespace GameEngineUsage
{
    public class MyVector3
    {
        public int x;
        public int y;
        public int z;

        public MyVector3(int posX, int posY, int posZ)
        {
            x = posX;
            y = posY;
            z = posZ;
        }

        public MyVector3(Vector3 conv)
        {
            x = (int)conv.x;
            y = (int)conv.y;
            z = (int)conv.z;
        }

        public Vector3 GetUnityVector()
        {
            return new Vector3(x,y,z);
        }

        public int GetSquareDist(MyVector3 to)
        {
            return (to.x - x) * (to.x - x) + (to.y - y) * (to.y - y) + (to.z - z) * (to.z - z);
        }
    }
}