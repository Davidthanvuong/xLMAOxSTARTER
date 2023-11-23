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
        public static List<AppInfo> AppInfos
        {
            get => Get<List<AppInfo>>("AppInfos").GetAwaiter().GetResult();
            set { Set("AppInfos", value).Wait(); }
        }

        public static void Reset()
        {
            Set("AppInfos", AppInfo.SampleUsages).Wait();
        }
    }
}
