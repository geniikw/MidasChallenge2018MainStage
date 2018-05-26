using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MidasMain.BaseClass
{
    //전체를 포함하는 문서
    class Document
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

        public Room GetRoom(int id)
        {
            return rooms[id];
        }
        
    }
}
