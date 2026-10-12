using System.Globalization;

namespace TiemTapHoa;

static class Program
{
    [STAThread]
    static void Main()
    {
        var vi = new CultureInfo("vi-VN");
        CultureInfo.DefaultThreadCurrentCulture = vi;
        CultureInfo.DefaultThreadCurrentUICulture = vi;
        Thread.CurrentThread.CurrentCulture = vi;
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
