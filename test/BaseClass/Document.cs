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

        public Document()
        {
            rooms = new List<Room>();
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
                                    near = space[j + 1, k];
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
                            if (k - 1 > 0 && space[j, k - 1] == -1)
                            {
                                endCondition = true;
                            }
                            if (k + 1 < h && space[j, k + 1] == -1)
                            {
                                endCondition = true;
                            }
                            if (j + 1 < w && space[j + 1, k] != -1)
                            {
                                endCondition = true;
                            }
                            if (endCondition)
                            {
                                started = false;
                                ret.Add(new Line(new System.Drawing.Point(from, k),
                                    new System.Drawing.Point(j, k)));
                            }
                            else
                            {

                                if (passBy.Count < 2)
                                {
                                    int near = -1;
                                    if (k - 1 < 0)
                                    {
                                        if (!passBy.Contains(0))
                                        {
                                            passBy.Add(0);
                                        }
                                    }
                                    else if (space[k, j - 1] != -1)
                                    {
                                        near = space[k, j - 1];
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
        public List<Line> GetLinesOfRoom()
        {
            List<Line> ret = new List<Line>();

            int left = int.MinValue;
            int right = int.MaxValue;
            int bottom = int.MaxValue;
            int top = int.MinValue;
            foreach (var r in rooms)
            {
                if(left < r.Rect.Left)
                {
                    left = r.Rect.Left;
                }
                if (right > r.Rect.Right)
                {
                    right = r.Rect.Right;
                }
                if (bottom > r.Rect.Bottom)
                {
                    bottom = r.Rect.Bottom;
                }
                if (top < r.Rect.Top)
                {
                    top = r.Rect.Top;
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

            ret.AddRange(GetHorizontalLines(ref space, right, bottom));
            ret.AddRange(GetVerticalLines(ref space, right, bottom));

            return ret;
        }
    }
}
