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

        public static string readItemPath(string filename) {
            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), filename);
        }

        public static string[] readItemNames(string path) {
            string dirpath = readItemPath(path);
            string[] files = System.IO.Directory.GetFiles(dirpath, "*.*", System.IO.SearchOption.TopDirectoryOnly);
            for (int i = 0; i < files.Length; i++) {
                files[i]=System.IO.Path.GetFileNameWithoutExtension(files[i]);
            }
            return files;            
        }

        public SymbolList(string n){
            name = n;
        }

        private string getTxtfilename() {
            string filename = String.Format(@"SymbolList\{0}.txt", name);
            return filename;
        }

        private void replace(ref string[] s, string oldone, string newone) {
            for (int i = 0; i < s.Length; i++) {
                s[i] = s[i].Replace(oldone, newone);
            }
        }

        public string[] getlist(){
            string filename = this.getTxtfilename();
            string[] lines = System.IO.File.ReadAllLines(SymbolList.readItemPath(filename));
            this.replace(ref lines, "\t", " ");
            return lines;
        }
    }
}
