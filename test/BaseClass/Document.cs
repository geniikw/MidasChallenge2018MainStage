using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MidasMain.BaseClass
{
    //전체를 포함하는 문서
    public class Document
    {
        // 룸 과 아이디
        Dictionary<int, Room> rooms;

        public Document()
        {
            rooms = new Dictionary<int, Room>();
        }

        //아이디가 존재하면 return false
        public bool AddRoom(int id, Room room)
        {
            if(rooms.ContainsKey(id))
            {
                return false;
            }
            else
            {
                rooms.Add(id, room);
                return true;
            }

        }

        public void RemoveRoom(int id)
        {
            if (rooms.ContainsKey(id))
            {
                rooms.Remove(id);
            }
        }

        public Room GetRoom(int id)
        {
            return rooms[id];
        }


        public List<Line> GetLinesOfRoom(Room room)
        {
            var sorted = rooms.OrderBy(r => -r.Value.Depth);

            List<Line> lines = new List<Line>();

            foreach (var rm in sorted)
            {

                //첫 아이템 이니셜라이즈
                if(lines.Count == 0)
                {
                    var init = rm.Value.ConvertRectToLines();
                    foreach (var l in init)
                    {
                        l.from = rm.Value;
                        lines.Add(l);
                    }
                    continue;
                }


                var rectLines = rm.Value.ConvertRectToLines();
                foreach( var l in rectLines)
                {
                    l.from = rm.Value;
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
