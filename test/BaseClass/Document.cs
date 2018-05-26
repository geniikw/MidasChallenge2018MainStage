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
        
    }
}
