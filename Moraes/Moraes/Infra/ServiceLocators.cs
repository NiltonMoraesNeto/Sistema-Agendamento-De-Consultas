using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moraes.Infra
{
    public static class ServiceLocators
    {
        private static IDictionary<string, Object> services = new Dictionary<string, Object>();
        public static T Get<T>()
        {
            string serviceName = typeof(T).Name;
            return (T)services[serviceName];
        }
        public static bool Has<T>()
        {
            string serviceName = typeof(T).Name;
            return services.ContainsKey(serviceName);
        }
        public static void Register<T>(T service)
        {
            string serviceName = typeof(T).Name;
            services.Add(new KeyValuePair<string, Object>(serviceName, service));
        }
    }
}
