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

        // This method is called when the folder needs to be loaded with items
        public override void Load()
        {
            base.Load();
        }

        // This method is called when the folder is opened
        public override void Opened()
        {
            base.Opened();
        }
    }
}
