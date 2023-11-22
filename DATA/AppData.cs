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
        public async static Task Set<T>(string key, T value) 
        {
            string json = JsonConvert.SerializeObject(value);
            await SecureStorage.Default.SetAsync("appdata_" + key, json);
        }
        public async static Task<T> Get<T>(string key)
        {
            string value = await SecureStorage.Default.GetAsync("appdata_" + key);
            return JsonConvert.DeserializeObject<T>(value);
        }
        public bool Remove(string key)
        {
            return SecureStorage.Default.Remove("appdata_" + key);
        }
        public List<AppInfo> appInfos
        {
            get => Get<List<AppInfo>>("appinfos").GetAwaiter().GetResult();
            set { Set("appinfos", value).Wait(); }
        }
    }
}
