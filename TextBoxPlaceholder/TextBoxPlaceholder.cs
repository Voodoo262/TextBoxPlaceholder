using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Com.RobFaust.Common.UserInterface
{
    public class TextBoxPlaceholder : TextBox
    {
        private bool isEmpty;
        private string placeholder;

        public TextBoxPlaceholder()
        {
            InitializeComponent();
            Enter += HandleEnter;
            Leave += HandleLeave;
            TextChanged += HandleTextChanged;
            if (string.IsNullOrEmpty(Text))
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
            OnLeave(EventArgs.Empty);
        }

        protected virtual void HandleEnter(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                base.Text = string.Empty;
            }
            ForeColor = SystemColors.WindowText;
        }

        protected virtual void HandleLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                isEmpty = true;
                base.Text = placeholder;
                UpdateColor();
            }
            else
            {
                isEmpty = false;
            }
        }

        protected virtual void HandleTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
        }

        [Category("Appearance"), DefaultValue(""), Description("The text shown, in light gray, when the value of the textbox is empty.")]
        public string Placeholder
        {
            get => placeholder;
            set
            {
                placeholder = value;
                if (isEmpty)
                {
                    base.Text = value;
                }
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
                isEmpty = true;
                base.Text = Placeholder;
                UpdateColor();
            }
            else
            {
                isEmpty = false;
            }
        }

        public new string Text
        {
            get
            {
                if (isEmpty)
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
                if (string.IsNullOrEmpty(value))
                {
                    isEmpty = true;
                    base.Text = Placeholder;
                }
                else
                {
                    isEmpty = false;
                    base.Text = value;
                }
                UpdateColor();
            }
        }

        private void UpdateColor()
        {
            if (string.IsNullOrEmpty(Text))
            {
                ForeColor = SystemColors.GrayText;
            }
            else
            {
                ForeColor = SystemColors.WindowText;
            }
        }
    }
}
