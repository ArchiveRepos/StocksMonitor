using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SymbolList
{
    public class SymbolList{

        private string name;
        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public SymbolList(string n){
            name = n;
        }

        public string[] getlist(){
            string filename = String.Format(@"SymbolList\{0}.txt", name);
            string[] lines = System.IO.File.ReadAllLines(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) , filename));
            for (int i = 0; i < lines.Length; i++ ) {
                lines[i]=lines[i].Replace("\t", " ");
            }
            return lines;
        }
    }
}
