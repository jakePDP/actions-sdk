namespace Loupedeck.DemoPlugin
{
    using System;

    // This command shows the View options for the current Finder view
    public class FinderViewOptionsCommand : PluginDynamicCommand
    {
        public FinderViewOptionsCommand()
            : base(displayName: "View Options", description: "Shows view options for the current folder", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+J in Finder shows view options
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.VK_J, ShiftKeyFlags.Command);
        }
    }
}
