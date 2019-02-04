namespace TreehouseDefense {
 class Map {
                        
           public readonly int Width;
           public readonly int Height;
            
            public Map(int width, int height)
            {
              Width = width;
              Height = height;
              
            }
   
          //method that takes a point on the map and will message if the point is not on the map
            public bool OnMap (Point point)
            { 
              return point.X >= 0 && 
                     point.X < Width &&
                     point.Y >= 0 &&
                     point.Y < Height;
              
            }
   
   
            }
  
}
