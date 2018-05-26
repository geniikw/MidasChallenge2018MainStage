using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MidasMain
{
    //전체를 포함하는 문서
    public class Document
    {
        // 룸 과 아이디
        public List<Room> rooms;
        public List<Furniture> objects;
        public List<Line> lines;
        public List<Door> doors;
        
        public Document()
        {
            rooms = new List<Room>();
            objects = new List<Furniture>();
            lines = new List<Line>();
            doors = new List<Door>();
        }

        //아이디가 존재하면 return false
        public void AddRoom(Room room)
        {
            rooms.Add(room);

        }


        public Room GetRoom(int id)
        {
            return rooms[id];
        }

        private List<Line> GetHorizontalLines(ref int[,] space, int w, int h)
        {
            List<Line> ret = new List<Line>();

            List<int> passBy = new List<int>();
            for(int k = 0; k < h; k++)
            {
                bool started = false;
                int from = 0;
                for(int j = 0; j < w; j++)
                {
                    int val = space[j, k];
                    if(val == -1) // wall
                    {
                        if(started == false)
                        {
                            started = true;
                            from = j;
                        }
                        else
                        {

                            bool endCondition = false;
                            if(k-1 > 0 && space[j, k - 1] == -1)
                            {
                                endCondition = true;
                            }
                            else if(k +1 < h && space[j, k+1] == -1)
                            {
                                endCondition = true;
                            }
                            else if(j+1 < w && space[j + 1, k] != -1)
                            {
                                endCondition = true;
                            }
                            else
                            {

                                if(passBy.Count < 2)
                                {
                                    int near = -1;
                                    if (k - 1 < 0 )
                                    {
                                        if (!passBy.Contains(0))
                                        {
                                            passBy.Add(0);
                                        }
                                    }
                                    else if(space[j, k - 1] != -1)
                                    {
                                        near = space[j, k - 1];
                                        if (near >= 0)
                                        {
                                            if (!passBy.Contains(near))
                                            {
                                                passBy.Add(near);
                                            }
                                        }
                                        
                                    }
                                    near = space[j , k + 1];
                                    if(!passBy.Contains(near) && near >= 0)
                                    {
                                        passBy.Add(near);
                                    }
                                }
                                
                            }
                            if(endCondition)
                            {
                                
                                started = false;
                                Room f = null;
                                Room t = null;
                                if(passBy.Count > 0)
                                {
                                    f = rooms.Where(x => x.Depth == passBy[0]).FirstOrDefault();
                                }
                                if(passBy.Count  > 1)
                                {
                                    t = rooms.Where(x => x.Depth == passBy[1]).FirstOrDefault();
                                }

                                Line li = new Line(new System.Drawing.Point(from, k),
                                    new System.Drawing.Point(j, k), f, t);
                                    
                                
                                ret.Add(li);
                                passBy.Clear();
                            }
                        }
                    }
                    else
                    {
                        started = false;
                        passBy.Clear();
                    }
                    
                    
                    
                }
            }

            return ret;
        }
        private List<Line> GetVerticalLines(ref int[,] space, int w, int h)
        {
            List<Line> ret = new List<Line>();

            List<int> passBy = new List<int>();

            for (int k = 0; k < w; k++)
            {
                bool started = false;
                int from = 0;
                for (int j = 0; j < h; j++)
                {
                    int val = space[k, j];
                    if (val == -1) // wall
                    {
                        if (started == false)
                        {
                            started = true;
                            from = j;
                        }
                        else
                        {
                            bool endCondition = false;
                            if (k - 1 > 0 && space[k -1, j] == -1)
                            {
                                endCondition = true;
                            }
                            else if (k + 1 < w && space[k + 1, j] == -1)
                            {
                                endCondition = true;
                            }
                            else if (j + 1 < h && space[k, j +1] != -1)
                            {
                                endCondition = true;
                            }
                            else
                            {

                                if (passBy.Count < 2)
                                {
                                    int near = -1;
                                    if (j - 1 < 0)
                                    {
                                        if (!passBy.Contains(0))
                                        {
                                            passBy.Add(0);
                                        }
                                    }
                                    else if (space[k -1, j] != -1)
                                    {
                                        near = space[k - 1, j];
                                        if (near >= 0)
                                        {
                                            if (!passBy.Contains(near))
                                            {
                                                passBy.Add(near);
                                            }
                                        }

                                    }
                                    near = space[k + 1, j];
                                    if (!passBy.Contains(near) && near >= 0)
                                    {
                                        passBy.Add(near);
                                    }
                                }

                            }
                            if (endCondition)
                            {

                                started = false;
                                Room f = null;
                                Room t = null;
                                if (passBy.Count > 0)
                                {
                                    f = rooms.Where(x => x.Depth == passBy[0]).FirstOrDefault();
                                }
                                if (passBy.Count > 1)
                                {
                                    t = rooms.Where(x => x.Depth == passBy[1]).FirstOrDefault();
                                }

                                Line li = new Line(new System.Drawing.Point(k, from),
                                    new System.Drawing.Point(k, j),f,t);


                                ret.Add(li);
                                passBy.Clear();
                            }
                        }
                    }
                    else
                    {
                        started = false;
                    }
                }
            }

            return ret;
        }

        public void DrawRect(ref int[,] space, Rectangle rect, int depth)
        {
            for(int k = rect.Left; k < rect.Left + rect.Width; k++)
            {
                for(int j = rect.Top; j < rect.Top + rect.Height; j++)
                {
                    if(k == rect.Left || k == rect.Left + rect.Width - 1 
                        || j ==rect.Top ||  j == rect.Top + rect.Height - 1)
                    {
                        space[k, j] = -1;
                    }
                    else
                    {
                        space[k, j] = depth;
                    }
                }
            }
        }
        public void GetLinesOfRoom()
        {
            lines.Clear();

            int left = int.MinValue;
            int right = int.MinValue;
            int bottom = int.MinValue;
            int top = int.MinValue;

            if (rooms.Count == 0)
                return;

            foreach (var r in rooms)
            {
                if (right < r.Rect.Left + r.Rect.Width )
                {
                    right = r.Rect.Left + r.Rect.Width;
                }
                if (bottom < r.Rect.Top + r.Rect.Height)
                {
                    bottom = r.Rect.Top + r.Rect.Height;
                }

            }

            int[,] space = new int[right + 1, bottom +1];

            foreach (var r in rooms)
            {
                DrawRect(ref space, r.Rect, r.Depth);
            }
            //var list = GetHorizontalLines(ref space, right, bottom);

            /*
            var list =GetHorizontalLines(ref space, right, bottom);
            foreach(var line in list)
            {
                if(line.from == room || line.to == room)
                {
                    ret.Add(line);
                }
            }
            list = GetVerticalLines(ref space, right, bottom);
            foreach (var line in list)
            {
                if (line.from == room || line.to == room)
                {
                    ret.Add(line);
                }
            }*/

            lines.AddRange(GetHorizontalLines(ref space, right, bottom));
            lines.AddRange(GetVerticalLines(ref space, right, bottom));

            //return lines;
        }
        public bool ValidateConstruction2()
        {
            GetLinesOfRoom();
            List<Rectangle> connectedWalls = new List<Rectangle>();


            // 연결되어있는 벽들을 불러옴
            foreach (var line in lines)
            {
                var lineRect = line.ToRect();
                foreach (var door in doors)
                {
                    var tempLine = new Line(door.pA, door.pB);
                    var doorRect = tempLine.ToRect();

                    if (doorRect.IntersectsWith(lineRect))
                    {
                        doorRect.Intersect(lineRect);
                        connectedWalls.Add(doorRect);
                        break;
                    }
                }
            }

            int right = int.MinValue;
            int bottom = int.MinValue;
            foreach (var r in rooms)
            {
                if (right < r.Rect.Left + r.Rect.Width)
                {
                    right = r.Rect.Left + r.Rect.Width;
                }
                if (bottom < r.Rect.Top + r.Rect.Height)
                {
                    bottom = r.Rect.Top + r.Rect.Height;
                }

            }

            int[,] space = new int[right + 1, bottom + 1];

            int depth = 1;
            foreach (var r in rooms)
            {
                DrawRect(ref space, r.Rect, depth++);
                
            }

            foreach(var door in doors)
            {
                var rect = new Line(door.pA, door.pB).ToRect();
                FillRect(ref space, rect, 0);
            }

            return CheckSpaceValidate(ref space, right, bottom);

        }
        private void FillRect(ref int[,] space, Rectangle rect, int depth)
        {
            int w = rect.Width == 0 ? 1 : rect.Width;
            int h = rect.Height == 0 ? 1 : rect.Width;
            for (int k = rect.Left; k < rect.Left + w; k++)
            {
                for (int j = rect.Top; j < rect.Top + h; j++)
                {
                    space[k, j] = depth;
                    
                }
            }
        }
        private bool CheckSpaceValidate(ref int[,] space, int w, int h)
        {
            for(int k = 0; k < w; k++)
            {
                for(int j = 0; j < h; j++)
                {
                    if(space[k,j] == 0) // empty
                    {
                        ZeroVirus(ref space, w, h, k, j);
                    }
                }
            }

            bool success = true;
            for (int k = 0; k < w; k++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (space[k, j] > 0) // not wall not 
                    {
                        success = false;
                        break;
                    }
                }
            }

            return success;
        }
        private void ZeroVirus(ref int[,] space, int w, int h, int x, int y, bool checkZero = false)
        {
            if (x < 0)
                return;
            if (y < 0)
                return;
            if (y >= h)
                return;
            if (x >= w)
                return;
            if (space[x, y] == -1) // wall
                return;
            if (checkZero && space[x, y] == 0)
                return;

            space[x, y] = 0;
            ZeroVirus(ref space, w, h, x + 1, y, true);
            ZeroVirus(ref space, w, h, x - 1, y, true);
            ZeroVirus(ref space, w, h, x , y + 1, true);
            ZeroVirus(ref space, w, h, x , y - 1, true);
        }

        public bool ValidateConstruction()
        {
            GetLinesOfRoom();
            List<Line> connectedWalls = new List<Line>();


            // 연결되어있는 벽들을 불러옴
            foreach (var line in lines)
            {
                var lineRect = line.ToRect();
                foreach (var door in doors)
                {
                    var tempLine = new Line(door.pA, door.pB);
                    var doorRect = tempLine.ToRect();

                    if (doorRect.IntersectsWith(lineRect))
                    {
                        connectedWalls.Add(line);
                        break;
                    }
                }
            }


            Dictionary<Room, int> dict = new Dictionary<Room, int>();
            Room currentRoom = null;
            List<Room> previousRoom = new List<Room>();
            List<Room> nextRoom = new List<Room>();


            var fromOutside = connectedWalls.Where(x => (x.from == currentRoom || x.to == currentRoom));
            foreach (var wall in fromOutside)
            {
                if (wall.from == currentRoom && wall.to != null)
                {
                    if (!dict.ContainsKey(wall.to))
                    {
                        dict.Add(wall.to, 1);
                        previousRoom.Add(wall.to);
                    }
                    //connectedWalls.Remove(wall);
                }
                else if (wall.to == currentRoom && wall.from != null)
                {
                    if (!dict.ContainsKey(wall.from))
                    {
                        dict.Add(wall.from, 1);
                        previousRoom.Add(wall.from);
                    }
                    //connectedWalls.Remove(wall);
                }
            }

            for(int j = 0; j < connectedWalls.Count; j++)
            {
                nextRoom.Clear();
                for (int k = 0; k < previousRoom.Count; k++)
                {
                    currentRoom = previousRoom[k];
                    fromOutside = connectedWalls.Where(x => (x.from == currentRoom || x.to == currentRoom));
                    foreach (var wall in fromOutside)
                    {
                        if (wall.from == currentRoom && wall.to != null)
                        {
                            if (!dict.ContainsKey(wall.to))
                            {
                                dict.Add(wall.to, 1);
                                nextRoom.Add(wall.to);
                            }
                            //connectedWalls.Remove(wall);
                        }
                        else if (wall.to == currentRoom && wall.from != null)
                        {
                            if (!dict.ContainsKey(wall.to))
                            {
                                dict.Add(wall.from, 1);
                                nextRoom.Add(wall.from);
                            }
                            //connectedWalls.Remove(wall);
                        }
                    }
                }
                previousRoom.Clear();
                previousRoom = nextRoom.ToList();
                
            }
            
            if(dict.Count == rooms.Count)
            {
                return true;
            }

            return false; 

        }
        
    }
}
