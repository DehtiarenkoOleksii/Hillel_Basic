using System;

namespace Interfaces
{
    /// <summary>
    /// Class for managing plugins
    /// </summary>
    public class PluginManager
    {
        // List for saving loaded plugins
        private List<IPlugin> plugins = new List<IPlugin>();

        // Method for loading plugins
        public void LoadPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
        }

        // Executes all loaded plugins
        public void ExecuteAllPlugins()
        {
            foreach (var plugin in plugins)
            {
                plugin.Execute();
            }
        }
    }
}
