using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TheWarTime.ConfigHandler
{
    internal class JsonHandler : IDisposable
    {

        private readonly string _workingDirectory = Environment.CurrentDirectory;
        private readonly string _filename = "defaultConfig.json";
        private readonly string _path;
        public Root? Root {get; private set; }
        public JsonHandler()
        {
            _path = Path.Combine(Directory.GetParent(_workingDirectory)!.Parent!.Parent!.FullName, @"Configs\",
                this._filename);
            this.Root = this.DeserializeRoot();
        }
        public JsonHandler(string _filename)
        {
            _path = Path.Combine(Directory.GetParent(_workingDirectory)!.Parent!.Parent!.FullName, @"Configs\",
                _filename);
            this.Root = this.DeserializeRoot();
        }
        public Root? DeserializeRoot()
        {
            string json = File.ReadAllText(_path);
            var root = JsonConvert.DeserializeObject<Root>(json)!;
            return root;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
