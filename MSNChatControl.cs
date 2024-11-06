using AxMSNChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MSNChatControlLibrary
{
    [DesignerCategory("")]
    public partial class MSNChatControl : UserControl
    {
        private AxMSNChatFrame axChatFrame;
        private Dictionary<string, object> propertyValues = new Dictionary<string, object>();
        private bool interfacesAttached = false;

        public MSNChatControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // MSNChatControl
            // 
            Name = "MSNChatControl";
            Load += MSNChatControl_Load;
            Size = new Size(640, 480);
            ResumeLayout(false);
        }

        private void AxChatFrame_ControlReady(object sender, EventArgs e)
        {
            interfacesAttached = true;
            foreach (var property in propertyValues)
            {
                var propertyInfo = typeof(AxMSNChatFrame).GetProperty(property.Key);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(axChatFrame, property.Value, null);
                }
            }
            propertyValues.Clear();
        }

        private void SetPropertyValue(string propertyName, object value)
        {
            if (interfacesAttached)
            {
                var propertyInfo = typeof(AxMSNChatFrame).GetProperty(propertyName);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(axChatFrame, value, null);
                }
            }
            else
            {
                propertyValues[propertyName] = value;
            }
        }

        private void MSNChatControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                // The MSN Chat Control / Chat Frame will not load in the designer due to /NXCOMPAT:NO needing to be set.
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
            // Initialize AxMSNChatFrame
            axChatFrame = new AxMSNChatFrame();
            axChatFrame.Dock = DockStyle.Fill;
            axChatFrame.ControlReady += AxChatFrame_ControlReady;

            // We need a couple of defaults set here to run in UserControl TestContainer.
            Server = "dir.irc7.com:6667";
            RoomName = "The Lobby";
            NickName = "Anon";
            BaseURL = "http://chat.msn.com/";

            Controls.Add(axChatFrame);
        }

        private T GetPropertyValue<T>(string propertyName)
        {
            if (interfacesAttached)
            {
                var propertyInfo = typeof(AxMSNChatFrame).GetProperty(propertyName);
                if (propertyInfo != null)
                {
                    return (T)propertyInfo.GetValue(axChatFrame, null);
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

        // Properties to expose AxMSNChatFrame properties
        [DefaultValue(typeof(Color), "255, 255, 231")]
        public new Color BackColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(BackColor));
                return value == default ? Color.FromArgb(255, 255, 231) : value;
            }
            set
            {
                SetPropertyValue(nameof(BackColor), value);
                base.BackColor = value;
            }
        }

        [DefaultValue("The Lobby")]
        public string RoomName
        {
            get
            {
                var value = GetPropertyValue<string>(nameof(RoomName));
                return value == default ? "The Lobby" : value;
            }
            set
            {
                SetPropertyValue(nameof(RoomName), value);
            }
        }

        [DefaultValue("")]
        public string HexRoomName
        {
            get
            {
                return GetPropertyValue<string>(nameof(HexRoomName));
            }
            set
            {
                SetPropertyValue(nameof(HexRoomName), value);
            }
        }

        [DefaultValue("Anon")]
        public string NickName
        {
            get
            {
                var value = GetPropertyValue<string>(nameof(NickName));
                return value == default ? "Anon" : value;
            }
            set
            {
                SetPropertyValue(nameof(NickName), value);
            }
        }

        [DefaultValue("dir.irc7.com:6667")]
        public string Server
        {
            get
            {
                var value = GetPropertyValue<string>(nameof(Server));
                return value == default ? "dir.irc7.com:6667" : value;
            }
            set
            {
                SetPropertyValue(nameof(Server), value);
            }
        }

        [DefaultValue(typeof(Color), "239, 239, 247")]
        public Color BackHighlightColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(BackHighlightColor));
                return value == default ? Color.FromArgb(239, 239, 247) : value;
            }
            set
            {
                SetPropertyValue(nameof(BackHighlightColor), value);
            }
        }

        [DefaultValue(typeof(Color), "102, 153, 255")]
        public Color ButtonFrameColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(ButtonFrameColor));
                return value == default ? Color.FromArgb(102, 153, 255) : value;
            }
            set
            {
                SetPropertyValue(nameof(ButtonFrameColor), value);
            }
        }

        [DefaultValue(typeof(Color), "165, 178, 206")]
        public Color TopBackHighlightColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(TopBackHighlightColor));
                return value == default ? Color.FromArgb(165, 178, 206) : value;
            }
            set
            {
                SetPropertyValue(nameof(TopBackHighlightColor), value);
            }
        }

        [DefaultValue(0)]
        public int ChatMode
        {
            get
            {
                return GetPropertyValue<int>(nameof(ChatMode));
            }
            set
            {
                SetPropertyValue(nameof(ChatMode), value);
            }
        }

        [DefaultValue("")]
        public string URLBack
        {
            get
            {
                return GetPropertyValue<string>(nameof(URLBack));
            }
            set
            {
                SetPropertyValue(nameof(URLBack), value);
            }
        }

        [DefaultValue("")]
        public string Category
        {
            get
            {
                return GetPropertyValue<string>(nameof(Category));
            }
            set
            {
                SetPropertyValue(nameof(Category), value);
            }
        }

        [DefaultValue("")]
        public string Topic
        {
            get
            {
                return GetPropertyValue<string>(nameof(Topic));
            }
            set
            {
                SetPropertyValue(nameof(Topic), value);
            }
        }

        [DefaultValue("")]
        public string WelcomeMsg
        {
            get
            {
                return GetPropertyValue<string>(nameof(WelcomeMsg));
            }
            set
            {
                SetPropertyValue(nameof(WelcomeMsg), value);
            }
        }

        [DefaultValue("http://chat.msn.com/")]
        public string BaseURL
        {
            get
            {
                var value = GetPropertyValue<string>(nameof(BaseURL));
                return value == default ? "http://chat.msn.com/" : value;
            }
            set
            {
                SetPropertyValue(nameof(BaseURL), value);
            }
        }

        [DefaultValue(typeof(Color), "74, 101, 156")]
        public Color InputBorderColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(InputBorderColor));
                return value == default ? Color.FromArgb(74, 101, 156) : value;
            }
            set
            {
                SetPropertyValue(nameof(InputBorderColor), value);
            }
        }

        [DefaultValue("")]
        public string CreateRoom
        {
            get
            {
                return GetPropertyValue<string>(nameof(CreateRoom));
            }
            set
            {
                SetPropertyValue(nameof(CreateRoom), value);
            }
        }

        [DefaultValue("")]
        public string ChatHome
        {
            get
            {
                return GetPropertyValue<string>(nameof(ChatHome));
            }
            set
            {
                SetPropertyValue(nameof(ChatHome), value);
            }
        }

        [DefaultValue("")]
        public string Locale
        {
            get
            {
                return GetPropertyValue<string>(nameof(Locale));
            }
            set
            {
                SetPropertyValue(nameof(Locale), value);
            }
        }

        [DefaultValue("")]
        public string ResDLL
        {
            get
            {
                return GetPropertyValue<string>(nameof(ResDLL));
            }
            set
            {
                SetPropertyValue(nameof(ResDLL), value);
            }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color ButtonTextColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(ButtonTextColor));
                return value == default ? Color.Black : value;
            }
            set
            {
                SetPropertyValue(nameof(ButtonTextColor), value);
            }
        }

        [DefaultValue(typeof(Color), "202, 224, 245")]
        public Color ButtonBackColor
        {
            get
            {
                var value = GetPropertyValue<Color>(nameof(ButtonBackColor));
                return value == default ? Color.FromArgb(202, 224, 245) : value;
            }
            set
            {
                SetPropertyValue(nameof(ButtonBackColor), value);
            }
        }

        [DefaultValue("")]
        public string PassportTicket
        {
            get
            {
                return GetPropertyValue<string>(nameof(PassportTicket));
            }
            set
            {
                SetPropertyValue(nameof(PassportTicket), value);
            }
        }

        [DefaultValue("")]
        public string PassportProfile
        {
            get
            {
                return GetPropertyValue<string>(nameof(PassportProfile));
            }
            set
            {
                SetPropertyValue(nameof(PassportProfile), value);
            }
        }

        [DefaultValue(0u)]
        public uint Feature
        {
            get
            {
                return GetPropertyValue<uint>(nameof(Feature));
            }
            set
            {
                SetPropertyValue(nameof(Feature), value);
            }
        }

        [DefaultValue("")]
        public string MessageOfTheDay
        {
            get
            {
                return GetPropertyValue<string>(nameof(MessageOfTheDay));
            }
            set
            {
                SetPropertyValue(nameof(MessageOfTheDay), value);
            }
        }

        [DefaultValue("")]
        public string ChannelLanguage
        {
            get
            {
                return GetPropertyValue<string>(nameof(ChannelLanguage));
            }
            set
            {
                SetPropertyValue(nameof(ChannelLanguage), value);
            }
        }

        [DefaultValue("")]
        public string InvitationCode
        {
            get
            {
                return GetPropertyValue<string>(nameof(InvitationCode));
            }
            set
            {
                SetPropertyValue(nameof(InvitationCode), value);
            }
        }

        [DefaultValue("")]
        public string NicknameToInvite
        {
            get
            {
                return GetPropertyValue<string>(nameof(NicknameToInvite));
            }
            set
            {
                SetPropertyValue(nameof(NicknameToInvite), value);
            }
        }

        [DefaultValue("")]
        public string MSNREGCookie
        {
            get
            {
                return GetPropertyValue<string>(nameof(MSNREGCookie));
            }
            set
            {
                SetPropertyValue(nameof(MSNREGCookie), value);
            }
        }

        [DefaultValue("")]
        public string CreationModes
        {
            get
            {
                return GetPropertyValue<string>(nameof(CreationModes));
            }
            set
            {
                SetPropertyValue(nameof(CreationModes), value);
            }
        }

        [DefaultValue("")]
        public string MSNProfile
        {
            get
            {
                return GetPropertyValue<string>(nameof(MSNProfile));
            }
            set
            {
                SetPropertyValue(nameof(MSNProfile), value);
            }
        }

        [DefaultValue("")]
        public string Market
        {
            get
            {
                return GetPropertyValue<string>(nameof(Market));
            }
            set
            {
                SetPropertyValue(nameof(Market), value);
            }
        }

        [DefaultValue("")]
        public string WhisperContent
        {
            get
            {
                return GetPropertyValue<string>(nameof(WhisperContent));
            }
            set
            {
                SetPropertyValue(nameof(WhisperContent), value);
            }
        }

        [DefaultValue("")]
        public string UserRole
        {
            get
            {
                return GetPropertyValue<string>(nameof(UserRole));
            }
            set
            {
                SetPropertyValue(nameof(UserRole), value);
            }
        }

        [DefaultValue("")]
        public string AuditMessage
        {
            get
            {
                return GetPropertyValue<string>(nameof(AuditMessage));
            }
            set
            {
                SetPropertyValue(nameof(AuditMessage), value);
            }
        }

        [DefaultValue("")]
        public string SubscriberInfo
        {
            get
            {
                return GetPropertyValue<string>(nameof(SubscriberInfo));
            }
            set
            {
                SetPropertyValue(nameof(SubscriberInfo), value);
            }
        }

        [DefaultValue("")]
        public string UpsellURL
        {
            get
            {
                return GetPropertyValue<string>(nameof(UpsellURL));
            }
            set
            {
                SetPropertyValue(nameof(UpsellURL), value);
            }
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
