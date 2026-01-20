namespace Loupedeck.DemoPlugin
{
    using System;

    // This command moves selected items to trash
    public class FinderMoveToTrashCommand : PluginDynamicCommand
    {
        public FinderMoveToTrashCommand()
            : base(displayName: "Move to Trash", description: "Moves selected items to the Trash", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Cmd+Delete in Finder moves items to trash
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Back, ShiftKeyFlags.Command);
        }
    }
}
