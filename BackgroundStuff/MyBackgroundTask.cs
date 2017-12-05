using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace BackgroundStuff
{
    // implement Background task interface
    public sealed class MyBackgroundTask : IBackgroundTask
    {
        // only has run method to run the task
        // when background task is invoked..it runs this method
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            SendToast("Todo saved to database");

            // throw new NotImplementedException();
        }
        public static void SendToast(string message)
        {
            //build toast
            var template = ToastTemplateType.ToastText01;
            var xml = ToastNotificationManager.GetTemplateContent(template);
            var elements = xml.GetElementsByTagName("text");
            var text = xml.CreateTextNode(message);
            elements[0].AppendChild(text);
            var toast = new ToastNotification(xml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
