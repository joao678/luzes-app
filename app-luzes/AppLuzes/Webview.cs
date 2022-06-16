using SharpWebview;
using SharpWebview.Content;
using System;

namespace webview_test
{
    public class Webview
    {
        [STAThread]
        static void Main()
        {
            using var webview = new SharpWebview.Webview(true,true);
            webview.SetTitle("Teste")
                .SetSize(1024, 768, WebviewHint.None)
                .SetSize(800, 600, WebviewHint.Min)
                .Navigate(new HostedContent());
            webview.Run();
        }
    }
}
