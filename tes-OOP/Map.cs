using System;
namespace tesOOP
{
    public class Map //*
    {
		public readonly int Height; //default access modifier is private if it's not declared
		public readonly int Width; //readonly so the value didn't change when looping program

        public Map(int height, int width) //harus sama *, constructor buat objek
        {
            Height = height;
            Width = width;
        }

        public bool onMap(Point point)
        {
            bool panjang = point.X < Width && point.X >= 0; //karena mulainya dari 0, maka batasnya < width
            bool lebar = point.Y < Height && point.Y >= 0;

            return panjang && lebar;
        }
    }
}
