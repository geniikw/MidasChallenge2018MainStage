﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.Canvas
{
    public partial class Canvas
    {
        public Document current;

        public void SetupDocument(Document doc)
        {
            current = doc;
            
            foreach(var room in doc.rooms)
            {
                var makeRoom = new UCRoom();
                makeRoom.roomData = room;
                makeRoom.Visible = true;
            }
        }

    }
}
