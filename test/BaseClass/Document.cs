using System;
using System.Collections.Generic;
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

        
        public List<Line> GetLinesOfRoom(Room room)
        {
            var sorted = rooms.OrderBy(r => -r.Depth);

            List<Line> lines = new List<Line>();

            foreach (var rm in sorted)
            {

                //첫 아이템 이니셜라이즈
                if(lines.Count == 0)
                {
                    var init = rm.ConvertRectToLines();
                    foreach (var l in init)
                    {
                        l.from = rm;
                        lines.Add(l);
                    }
                    continue;
                }


                var rectLines = rm.ConvertRectToLines();
                foreach( var l in rectLines)
                {
                    l.from = rm;
                }
            }

            List<Line> lineOfRoom = new List<Line>();
            foreach(var line in lines)
            {
                if(line.from == room || line.to == room)
                {
                    lineOfRoom.Add(line);
                }
            }

            return lineOfRoom;

        }
    }
}
