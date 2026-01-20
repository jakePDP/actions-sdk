namespace Loupedeck.DemoPlugin
{
    using System;

    // This command opens a new Finder window
    public class FinderNewWindowCommand : PluginDynamicCommand
    {
        public FinderNewWindowCommand()
            : base(displayName: "New Window", description: "Opens a new Finder window", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+N in Finder opens a new window
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.VK_N, ShiftKeyFlags.Command);
        }
    }
}
