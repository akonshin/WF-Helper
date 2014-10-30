using System;
using Microsoft.Win32;

namespace WFHelper.User_Classes
{
    public class WorkWithRegistry
    {
        public string ProjectName { get; private set; }
        public string Path { get; private set; }

        public WorkWithRegistry(string projectName, string path = "SOFTWARE\\")
        {
            ProjectName = projectName;
            Path = path;
        }

        public string ReadValue(string key)
        {
            var value = String.Empty;

            var readKey = Registry.LocalMachine.OpenSubKey(Path + ProjectName);

            if (readKey != null)
            {
                value = (string)readKey.GetValue(key);
                //readKey.Dispose();
            }

            return value;
        }

        public string[] ReadAllValues()
        {
            var readKey = Registry.LocalMachine.OpenSubKey(Path + ProjectName);

            if (readKey != null)
            {
                var allValuesFromRegistry = readKey.GetValueNames();
               // readKey.Dispose();
                return allValuesFromRegistry;
            }

            return null;
        }

        public int GetValuesCount()
        {
            var readKey = Registry.LocalMachine.OpenSubKey(Path + ProjectName);

            return readKey != null ? readKey.ValueCount : 0;
        }

        public void WriteValue(string key, string value, Boolean overrideValue = false)
        {
            if (!overrideValue) return;
            var saveKey = Registry.LocalMachine.CreateSubKey(Path + ProjectName);
            if (saveKey == null) return;
            saveKey.SetValue(key, value);
           // saveKey.Dispose();
        }

        public bool CheckValue(string value)
        {
            return !String.IsNullOrEmpty(ReadValue(value).Trim());
        }
    }
}
