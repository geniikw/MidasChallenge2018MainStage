using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasMain.UML
{
    [Serializable]
    public class UMLModel
    {
        public string modelName = "DefaultModel";
        public List<UMLObject> objectList = new List<UMLObject>();
    }

    [Serializable]
    public class UMLObject
    {
        public string name;
        public List<UMLMember> mList = new List<UMLMember>();
    }

    [Serializable]
    public class UMLMember
    {
        public enum EType
        {
            Prop,
            Field,
            Method
        }
        public EType memberType;
        public string returnType;
        public string name;
    }
    
}
