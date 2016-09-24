using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace mclip
{
    // http://stackoverflow.com/questions/3147043/bind-a-label-to-a-variable
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        public Form1()
        {            
            InitializeComponent();
            this.labelcsv.DataBindings.Add("Text", this, "containscsv");
            this.labelhtml.DataBindings.Add("Text", this, "containshtml");
            this.labelrtf.DataBindings.Add("Text", this, "containsrtf");
            this.labeltext.DataBindings.Add("Text", this, "containstext");
            this.labelunicode.DataBindings.Add("Text", this, "containsunicode");
            striptext = true;
            update_ui_striptext();
        }

        // blaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _containscsv;
        public bool containscsv
        {
            get { return _containscsv; }
            set
            {
                _containscsv = value;
                OnPropertyChanged("containscsv");
            }
        }
        private bool _containshtml;
        public bool containshtml
        {
            get { return _containshtml; }
            set
            {
                _containshtml = value;
                OnPropertyChanged("containshtml");
            }
        }
        private bool _containsrtf;
        public bool containsrtf
        {
            get { return _containsrtf; }
            set
            {
                _containsrtf = value;
                OnPropertyChanged("containsrtf");
            }
        }
        private bool _containstext;
        public bool containstext
        {
            get { return _containstext; }
            set
            {
                _containstext = value;
                OnPropertyChanged("containstext");
            }
        }
        private bool _containsunicode;
        public bool containsunicode
        {
            get { return _containsunicode; }
            set
            {
                _containsunicode = value;
                OnPropertyChanged("containsunicode");
            }
        }
        
        // bla
        public bool striptext { get; set; }

        /*
        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        */

        protected virtual void OnPropertyChanged(string property)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }

        // todo: breakout
        public bool IsHandleInProcess(IntPtr hwnd)
        {
            uint processId;
            int thisId = Process.GetCurrentProcess().Id;
            Win32.GetWindowThreadProcessId(hwnd, out processId);
            bool result = processId == thisId;
            return result;
        }

        // http://stackoverflow.com/questions/1555492/modifying-clipboard-contents-on-clipboard-change
        // giorgi answer is interesting too
        // http://msdn.microsoft.com/en-us/library/ms649041(VS.85).aspx
        // i can't get getclipboardowner to return something i can find in .net, though it is found (kind of) with spy++, wtf * 10
        // problem: google: CLIPBRDWNDCLASS getclipboardowner
        // http://us.generation-nt.com/answer/getclipboardowner-fails-return-correct-clipboard-owner-help-28442282.html
        private void clipboardMonitor1_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {        
            IntPtr clipowner = Win32.GetClipboardOwner();
            // i am clipboard owner, because i SetText below, which triggers change events, so we ignore these change events
            if (IsHandleInProcess(clipowner))
            {
                return;
            }

            if (striptext)
            {
                if (Clipboard.ContainsText(TextDataFormat.Rtf) || Clipboard.ContainsText(TextDataFormat.Html))
                {

                    var text = Clipboard.GetText();
                    if (text != null)
                    {
                        Clipboard.SetText(text);
                    }
                }
            }

            containscsv = Clipboard.ContainsText(TextDataFormat.CommaSeparatedValue);
            containshtml = Clipboard.ContainsText(TextDataFormat.Html);
            containsrtf = Clipboard.ContainsText(TextDataFormat.Rtf);
            containstext = Clipboard.ContainsText(TextDataFormat.Text);
            containsunicode = Clipboard.ContainsText(TextDataFormat.UnicodeText);
        }

        // http://stackoverflow.com/questions/3563889/how-to-let-windows-form-exit-to-system-tray
        // http://stackoverflow.com/questions/3571477/why-is-my-notifyicon-application-not-exiting-when-i-use-application-exit-or-fo
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // false when we call Application.Exit
            // (true if we call this.Close or user closes)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void update_ui_striptext()
        {
            if (striptext)
            {
                this.notifyIcon1.Icon = mclip.Properties.Resources.a;
            }
            else
            {
                this.notifyIcon1.Icon = mclip.Properties.Resources.b;
            }
            // derp.
            checkBox1.CheckedChanged -= checkBox1_CheckedChanged;
            checkBox1.Checked = striptext;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            stripTextToolStripMenuItem.CheckedChanged -= stripTextToolStripMenuItem_CheckedChanged;
            stripTextToolStripMenuItem.Checked = striptext;
            stripTextToolStripMenuItem.CheckedChanged += stripTextToolStripMenuItem_CheckedChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            striptext = checkBox1.Checked;
            update_ui_striptext();
        }

        private void stripTextToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            striptext = stripTextToolStripMenuItem.Checked;
            update_ui_striptext();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            restorewindow();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restorewindow();
        }

        void restorewindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }
    }
}
