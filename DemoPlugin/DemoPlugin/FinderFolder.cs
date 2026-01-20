namespace Loupedeck.DemoPlugin
{
    using System;

    // This class implements a dynamic toolbar for macOS Finder
    public class FinderFolder : PluginDynamicFolder
    {
        public FinderFolder()
        {
            this.DisplayName = "Finder Toolbar";
            this.GroupName = "Finder";
            this.Navigation = PluginDynamicFolderNavigation.None;
        }
    }
}
