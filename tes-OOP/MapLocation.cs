using System;
namespace tesOOP
{
    public class MapLocation : Point //menandakan bahwa mapLocation inheritance dari point
    {
		public MapLocation(int x, int y, Map map) : base(x,y) //mengambil dari base nilai x dan y / overloading
		{
            if (!map.onMap(this)) //jika titik ini tidak di map
                throw new OutOfBoundsException("point ga di map");
		}
    }
}
