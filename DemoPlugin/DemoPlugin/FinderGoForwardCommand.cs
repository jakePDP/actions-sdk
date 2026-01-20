namespace Loupedeck.DemoPlugin
{
    using System;

    // This command navigates forward to the next folder
    public class FinderGoForwardCommand : PluginDynamicCommand
    {
        public FinderGoForwardCommand()
            : base(displayName: "Go Forward", description: "Goes forward to the next folder", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+] in Finder goes forward
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.OemCloseBrackets, ShiftKeyFlags.Command);
        }
    }
}
