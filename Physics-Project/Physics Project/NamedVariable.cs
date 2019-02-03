using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    public class NamedVariable
    {
        string _Def;
        string _Name;
        BinTreeNode<string> _TreeOfDef;

        public NamedVariable(string name, string def)
        {
            _Name = name;
            _Def = def;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Def
        {
            get { return _Def; }
            set { _Def = value; }
        }
        public BinTreeNode<string> TreeOfDef
        {
            get { return _TreeOfDef; }
            set { _TreeOfDef = value; }
        }

        
    }
}
