using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace FontViewer
{
    class LocaleManager
    {
        private Dictionary<string, string> locale = new Dictionary<string, string>();

        public LocaleManager()
        {
            string culture = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName; // Get current UI culture
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("FontViewer.Properties.Locales." + culture + ".csv")))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        locale.Add(line.Split(';')[0], line.Split(';')[1]); // First column for keys, second for values
                    }
                }
            }
            catch
            {
                throw new FileNotFoundException("App does not support this locale");
            }
        }

        public string Get(string name)
        {
            if(locale.ContainsKey(name))
            {
                return locale[name];
            }
            else
            {
                throw new KeyNotFoundException("Current locale does not contain this key");
            }
        }
    }
}
