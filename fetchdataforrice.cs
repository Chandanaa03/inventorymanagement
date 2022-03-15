
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class fetchdataforrice
    {
        public Rice Read(string Path)
        {
           using(StreamReader file=new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);

                }catch(Exception e)
                {
                    return null;
                }
            }
        }

    }
}
