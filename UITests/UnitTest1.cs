using FlaUI.Core;
using FlaUI.UIA3;

namespace UITests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            using Application app = StartApplication();
            using UIA3Automation automation = new UIA3Automation();
            var window = app.GetMainWindow(automation, TimeSpan.FromSeconds(1));
            app.WaitWhileBusy();
            app.Close();
            Assert.Equal(0, app.ExitCode);
        }

        protected Application StartApplication()
        {
            return Application.Launch("notepad.exe");
        }

    }
}