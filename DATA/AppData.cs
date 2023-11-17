using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;

namespace xLMAOxSTARTER.DATA
{
    public class AppData
    {
        public async Task Set(string key, object value) 
        {
            string json = JsonConvert.SerializeObject(value);
            await SecureStorage.Default.SetAsync("appdata_" + key, json);
        }
        public async Task<object> Get(string key)
        {
            string value = await SecureStorage.Default.GetAsync("appdata_" + key);
            return JsonConvert.DeserializeObject<object>(value);
        }
        public bool Remove(string key)
        {
            return SecureStorage.Default.Remove("appdata_" + key);
        }
    }
}
