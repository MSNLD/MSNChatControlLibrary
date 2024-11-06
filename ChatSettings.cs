using AxMSNChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MSNChatControlLibrary
{
    [DesignerCategory("")]
    public partial class ChatSettingsControl : UserControl
    {
        private AxChatSettings axChatSettings;
        private Dictionary<string, object> propertyValues = new Dictionary<string, object>();
        private bool interfacesAttached = false;

        public ChatSettingsControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // ChatSettingsControl
            // 
            Name = "ChatSettingsControl";
            Load += ChatSettingsControl_Load;
            Size = new Size(410, 600);
            ResumeLayout(false);
        }

        private void AxChatSettings_ControlReady(object sender, EventArgs e)
        {
            interfacesAttached = true;
            foreach (var property in propertyValues)
            {
                var propertyInfo = typeof(AxChatSettings).GetProperty(property.Key);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(axChatSettings, property.Value, null);
                }
            }
            propertyValues.Clear();
        }

        private void SetPropertyValue(string propertyName, object value)
        {
            if (interfacesAttached)
            {
                var propertyInfo = typeof(AxChatSettings).GetProperty(propertyName);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(axChatSettings, value, null);
                }
            }
            else
            {
                propertyValues[propertyName] = value;
            }
        }

        private void ChatSettingsControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                // The MSN Chat Control / Chat Settings will not load in the designer due to /NXCOMPAT:NO needing to be set.
                var lbl = new Label();
                lbl.BackColor = BackColor;
                lbl.Dock = DockStyle.Fill;
                lbl.ForeColor = ForeColor;
                lbl.Font = new Font(Font.Name, 20F, Font.Style, Font.Unit, Font.GdiCharSet);
                lbl.Text = Name;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(lbl);
                return;
            }
            // Initialize AxChatSettings
            axChatSettings = new AxChatSettings();
            axChatSettings.Dock = DockStyle.Fill;
            axChatSettings.ControlReady += AxChatSettings_ControlReady;
            Controls.Add(axChatSettings);
        }

        private T GetPropertyValue<T>(string propertyName)
        {
            if (interfacesAttached)
            {
                var propertyInfo = typeof(AxChatSettings).GetProperty(propertyName);
                if (propertyInfo != null)
                {
                    return (T)propertyInfo.GetValue(axChatSettings, null);
                }
                return default;
            }
            else if (propertyValues.ContainsKey(propertyName))
            {
                return (T)propertyValues[propertyName];
            }
            else
            {
                return default;
            }
        }

        // Properties to expose AxChatSettings properties
        [DefaultValue(typeof(Color), "White")]
        public new Color BackColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(BackColor));
                return value == default ? Color.White : value;
            }
            set
            {
                SetPropertyValue(nameof(BackColor), value);
                base.BackColor = value;
            }
        }

        [DefaultValue(typeof(Color), "51, 51, 153")]
        public new Color ForeColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(ForeColor));
                return value == default ? Color.FromArgb(51, 51, 153) : value;
            }
            set
            {
                SetPropertyValue(nameof(ForeColor), value);
                base.ForeColor = value;
            }
        }

        [DefaultValue("")]
        public string RedirectURL
        {
            get
            {
                var value = GetPropertyValue<string>(nameof(RedirectURL));
                return value == default ? "" : value;
            }
            set { SetPropertyValue(nameof(RedirectURL), value); }
        }

        [DefaultValue("")]
        public string ResDLL
        {
            get
            {
                var value = GetPropertyValue<string>(nameof(ResDLL));
                return value == default ? "" : value;
            }
            set { SetPropertyValue(nameof(ResDLL), value); }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Enforce a fixed size of 410x600
            base.SetBoundsCore(x, y, 410, 600, specified);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (DesignMode)
            {
                foreach (Control control in Controls)
                {
                    control.BackColor = BackColor;
                }
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if (DesignMode)
            {
                foreach (Control control in Controls)
                {
                    control.ForeColor = ForeColor;
                }
            }
        }
    }
}
