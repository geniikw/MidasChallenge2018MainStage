using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.Canvas
{
    public interface IRoom
    {
        Room roomData { get; set; }
    }

    public partial class UCRoom : IRoom
    {
        Room cur_room;
        public Room roomData
        {
            get
            {
                return cur_room;
            }
            set
            {
                cur_room = value;
                if (cur_room == null)
                    return;
                Size = cur_room.Rect.Size;
                Location = cur_room.Rect.Location;                                
            }
        }
    }
}
