namespace Loupedeck.DemoPlugin
{
    using System;

    // This command duplicates selected items
    public class FinderDuplicateCommand : PluginDynamicCommand
    {
        public FinderDuplicateCommand()
            : base(displayName: "Duplicate", description: "Duplicates selected items", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+D in Finder duplicates items
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.VK_D, ShiftKeyFlags.Command);
        }
    }
}
