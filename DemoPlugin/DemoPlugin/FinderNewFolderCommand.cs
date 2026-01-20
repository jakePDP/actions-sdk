namespace Loupedeck.DemoPlugin
{
    using System;

    // This command creates a new folder in Finder
    public class FinderNewFolderCommand : PluginDynamicCommand
    {
        public FinderNewFolderCommand()
            : base(displayName: "New Folder", description: "Creates a new folder in the current location", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+Shift+N in Finder creates a new folder
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.VK_N, ShiftKeyFlags.Command | ShiftKeyFlags.Shift);
        }
    }
}
