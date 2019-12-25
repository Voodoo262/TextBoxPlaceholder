using System;
using System.Drawing;
using System.Windows.Forms;

namespace Com.RobFaust.Common.UserInterface
{
    class TextBoxPlaceholder : TextBox
    {
        private string placeholder;

        public TextBoxPlaceholder()
        {
            InitializeComponent();
            Enter += HandleEnter;
            Leave += HandleLeave;
            OnLeave(EventArgs.Empty);
        }

        protected virtual void HandleEnter(object sender, EventArgs e)
        {
            if (base.Text.Equals(Placeholder))
            {
                base.Text = string.Empty;
                ForeColor = SystemColors.WindowText;
            }
        }

        protected virtual void HandleLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                Text = Placeholder;
                ForeColor = SystemColors.GrayText;
            }
        }

        public string Placeholder
        {
            get => placeholder;
            set
            {
                placeholder = value;
                Text = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxPlaceholder
            // 
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.TextBoxPlaceholder_Layout);
            this.ResumeLayout(false);

        }

        private void TextBoxPlaceholder_Layout(object sender, LayoutEventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = Placeholder;
            }
        }

        public new string Text
        {
            get
            {
                if (base.Text.Equals(Placeholder))
                {
                    return string.Empty;
                }
                else
                {
                    return base.Text;
                }
            }
            set
            {
                base.Text = value;
            }
        }
    }
}
