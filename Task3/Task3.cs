using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Task3
    {
        public static Dictionary<string, int> GetWords(string path)
        {
            if (ReferenceEquals(path, null)) throw new ArgumentNullException(nameof(path));
            string text = System.IO.File.ReadAllText(path);
            string[] words = text.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var s in words)
            {
                if (s.Trim() != "")
                    if (!dict.ContainsKey(s))
                        dict.Add(s, 1);
                    else dict[s] += 1;
            }

            return dict;
        }
    }
}
