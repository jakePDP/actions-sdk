namespace Loupedeck.DemoPlugin
{
    using System;

    public class FinderApplication : ClientApplication
    {
        public FinderApplication()
        {
        }

        // This method can be used to link the plugin to a Windows application.
        protected override String GetProcessName() => "";

        // This method can be used to link the plugin to a macOS application.
        protected override String GetBundleName() => "com.apple.finder";
    }
}
