using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace mclip
{
    // http://www.developer.com/net/csharp/article.php/3359891/C-Tip-Monitoring-Clipboard-Activity-in-C.htm
    // http://stackoverflow.com/questions/621577/clipboard-event-c-sharp

    public class ClipboardChangedEventArgs : EventArgs
    {
        public readonly IDataObject DataObject;

        public ClipboardChangedEventArgs(IDataObject dataObject)
        {
            DataObject = dataObject;
        }
    }

    // Must inherit Control, not Component, in order to have Handle
    [DefaultEvent("ClipboardChanged")]
    public partial class ClipboardMonitor : Control 
    {
        IntPtr nextClipboardViewer;

        public ClipboardMonitor()
        {
            this.BackColor = Color.Red;
            this.Visible = false;

            nextClipboardViewer = (IntPtr)Win32.SetClipboardViewer((int)this.Handle);
        }

        /// <summary>
        /// Clipboard contents changed.
        /// </summary>
        public event EventHandler<ClipboardChangedEventArgs> ClipboardChanged;

        protected override void Dispose(bool disposing)
        {
            if(nextClipboardViewer != null)
                Win32.ChangeClipboardChain(this.Handle, nextClipboardViewer);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_DRAWCLIPBOARD:
                    OnClipboardChanged();
                    Win32.SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case Win32.WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        Win32.SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        void OnClipboardChanged()
        {
            try
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (ClipboardChanged != null)
                {
                    ClipboardChanged(this, new ClipboardChangedEventArgs(iData));
                }

            }
            catch (Exception e)
            {
                // Trace.Write(e.ToString());
                MessageBox.Show(e.ToString());
            }
        }
    }

}
