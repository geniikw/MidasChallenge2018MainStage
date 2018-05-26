using MidasMain.CanvasSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain
{
    public static class UndoManager
    {
        public static Stack<KeyValuePair<string, Document>> m_undo = new Stack<KeyValuePair<string, Document>>();
        public static Stack<KeyValuePair<string, Document>> m_redo = new Stack<KeyValuePair<string, Document>>();

        public static Action UndoCallback;

        public static void Record(Document doc, string msg)
        {
            m_undo.Push(new KeyValuePair<string, Document>(msg, doc));
        }

        public static void Undo()
        {
            var pair = m_undo.Pop();
            m_redo.Push(new KeyValuePair<string, Document>("undo", Canvas.instance.GetCurrent()));
            Canvas.instance.SetupDocument(pair.Value);
            UndoCallback?.Invoke();
            
        }

        public static void Redo()
        {
            var pair = m_redo.Pop();
            Canvas.instance.SetupDocument(pair.Value);
        }
    }
}
