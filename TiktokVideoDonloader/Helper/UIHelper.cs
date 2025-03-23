using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Helper
{
    public static class UIHelpers
    {
        public static void SafeUpdate(Control control, Action updateAction)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(updateAction));
            }
            else
            {
                updateAction();
            }
        }

        public static void UpdateProgress(ProgressBar pb, Label lbl, int percentage, long received, long total)
        {
            SafeUpdate(pb, () => pb.Value = percentage);
            SafeUpdate(lbl, () => lbl.Text = $"{percentage}% complete ({received}/{total})");
        }
    }
}
