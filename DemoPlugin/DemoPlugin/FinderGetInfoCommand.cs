namespace Loupedeck.DemoPlugin
{
    using System;

    // This command shows info for selected items
    public class FinderGetInfoCommand : PluginDynamicCommand
    {
        public FinderGetInfoCommand()
            : base(displayName: "Get Info", description: "Shows information about selected items", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+I in Finder shows the Get Info window
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.VK_I, ShiftKeyFlags.Command);
        }
    }
}
