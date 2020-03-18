using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Com.RjfTech.Common.UserInterface
{
    public class TextBoxPlaceholder : TextBox
    {
        private bool isEmpty = true;
        private string placeholder;
        private Color filledColor = SystemColors.WindowText;
        private Color emptyColor = SystemColors.GrayText;

        public TextBoxPlaceholder() : base()
        {
            
        }

        protected override void OnEnter(EventArgs e)
        {
            if (isEmpty)
            {
                base.Text = string.Empty;
                base.ForeColor = filledColor;
            }
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            UpdateText(base.Text);
            base.OnLeave(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (string.IsNullOrEmpty(base.Text) || base.Text.Equals(Placeholder))
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
            base.OnTextChanged(e);
        }

        [Category("Appearance"), DefaultValue(""), Description("The text shown, in light gray, when the value of the textbox is empty.")]
        public string Placeholder
        {
            get => placeholder;
            set
            {
                placeholder = value;
                UpdateText(Text);
            }
        }

        public new Color ForeColor
        {
            get => filledColor;
            set
            {
                filledColor = value;
                UpdateColor();
            }
        }

        [Category("Appearance"), Description("Defines the color of the placeholder text")]
        public Color PlaceholderColor
        {
            get => emptyColor;
            set
            {
                emptyColor = value;
                UpdateColor();
            }
        }

        public new virtual string Text
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
                UpdateText(value);
            }
        }

        private void UpdateText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                isEmpty = true;
                base.Text = Placeholder;
            }
            else
            {
                isEmpty = false;
                base.Text = text;
            }
            UpdateColor();
        }

        private void UpdateColor()
        {
            if (isEmpty)
            {
                base.ForeColor = emptyColor;
            }
            else
            {
                base.ForeColor = filledColor;
            }
        }
    }
}
