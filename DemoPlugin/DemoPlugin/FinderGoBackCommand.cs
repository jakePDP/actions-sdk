namespace Loupedeck.DemoPlugin
{
    using System;

    // This command navigates back to the previous folder
    public class FinderGoBackCommand : PluginDynamicCommand
    {
        public FinderGoBackCommand()
            : base(displayName: "Go Back", description: "Goes back to the previous folder", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+[ in Finder goes back
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.OemOpenBrackets, ShiftKeyFlags.Command);
        }
    }
}
