using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class FileNaming
    {
        public string[] fileNaming(string[] names)
        {
            var res = new List<string>();
            Dictionary<string,int> dict = new Dictionary<string, int>();


            foreach (var name in names)
            {
                if(!dict.ContainsKey(name))
                    dict.Add(name,0);
            }


            foreach (var name in names)
            {
                if (dict.ContainsKey(name))
                {
                    if (dict[name] == 0)
                    {
                        res.Add(name);
                        dict[name] = dict[name] + 1;
                    }
                    else
                    {
                        string n = name + "(" + dict[name] + ")";
                        
                        res.Add(n);

                        if (!dict.ContainsKey(n))
                            dict.Add(n, 0);
                        else
                        {
                            dict[n] = dict[n] + 1;
                            dict[name] = dict[name] + 1;
                        }
                        
                    }
                }
            }






            return res.ToArray();
        }


        

       
    }
}