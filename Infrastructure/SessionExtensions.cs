using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session,string key,object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session,string key)
        {
            var data = session.GetString(key);

            //data boş ise Generic T'nin (kart nesnesinin) defaultu ile json nesnesi alırız değil ise dönüştürürerek alırız
            return data == null ? default(T) : JsonConvert.DeserializeObject<T>(data);
        }
    }
}
