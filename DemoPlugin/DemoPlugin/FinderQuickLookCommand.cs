namespace Loupedeck.DemoPlugin
{
    using System;

    // This command activates Quick Look for selected items
    public class FinderQuickLookCommand : PluginDynamicCommand
    {
        public FinderQuickLookCommand()
            : base(displayName: "Quick Look", description: "Shows Quick Look preview for selected items", groupName: "Finder")
        {
        }

        protected override void RunCommand(String actionParameter)
        {
            // Space in Finder activates Quick Look
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.Space);
        }
    }
}
