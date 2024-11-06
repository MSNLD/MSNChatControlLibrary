using MSNChat;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AxMSNChat
{
  [DesignTimeVisible(true)]
  [AxHost.Clsid("{f58e1cef-a068-4c15-ba5e-587caf3ee8c6}")]
  public class AxMSNChatFrame : AxHost
  {
    private IChatFrame ocx;

    public AxMSNChatFrame()
      : base("f58e1cef-a068-4c15-ba5e-587caf3ee8c6")
    {
    }

    [DispId(-501)]
    [ComAliasName("System.UInt32")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Color BackColor
    {
      get
      {
        return this.ocx != null && this.PropsValid() ? AxHost.GetColorFromOleColor(this.ocx.BackColor) : base.BackColor;
      }
      set
      {
        base.BackColor = value;
        if (this.ocx == null)
          return;
        this.ocx.BackColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(2)]
    public virtual string RoomName
    {
      get
      {
        return this.ocx != null ? this.ocx.RoomName : throw new AxHost.InvalidActiveXStateException(nameof (RoomName), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (RoomName), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.RoomName = value;
      }
    }

    [DispId(3)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string HexRoomName
    {
      get
      {
        return this.ocx != null ? this.ocx.HexRoomName : throw new AxHost.InvalidActiveXStateException(nameof (HexRoomName), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (HexRoomName), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.HexRoomName = value;
      }
    }

    [DispId(4)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string NickName
    {
      get
      {
        return this.ocx != null ? this.ocx.NickName : throw new AxHost.InvalidActiveXStateException(nameof (NickName), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (NickName), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.NickName = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(5)]
    public virtual string Server
    {
      get
      {
        return this.ocx != null ? this.ocx.Server : throw new AxHost.InvalidActiveXStateException(nameof (Server), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (Server), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.Server = value;
      }
    }

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(6)]
    public virtual Color BackHighlightColor
    {
      get
      {
        return this.ocx != null ? AxHost.GetColorFromOleColor(this.ocx.BackHighlightColor) : throw new AxHost.InvalidActiveXStateException(nameof (BackHighlightColor), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (BackHighlightColor), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.BackHighlightColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(7)]
    public virtual Color ButtonFrameColor
    {
      get
      {
        return this.ocx != null ? AxHost.GetColorFromOleColor(this.ocx.ButtonFrameColor) : throw new AxHost.InvalidActiveXStateException(nameof (ButtonFrameColor), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ButtonFrameColor), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ButtonFrameColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [ComAliasName("System.UInt32")]
    [DispId(8)]
    public virtual Color TopBackHighlightColor
    {
      get
      {
        return this.ocx != null ? AxHost.GetColorFromOleColor(this.ocx.TopBackHighlightColor) : throw new AxHost.InvalidActiveXStateException(nameof (TopBackHighlightColor), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (TopBackHighlightColor), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.TopBackHighlightColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(9)]
    public virtual int ChatMode
    {
      get
      {
        return this.ocx != null ? this.ocx.ChatMode : throw new AxHost.InvalidActiveXStateException(nameof (ChatMode), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ChatMode), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ChatMode = value;
      }
    }

    [DispId(10)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string URLBack
    {
      get
      {
        return this.ocx != null ? this.ocx.URLBack : throw new AxHost.InvalidActiveXStateException(nameof (URLBack), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (URLBack), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.URLBack = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(11)]
    public virtual string Category
    {
      get
      {
        return this.ocx != null ? this.ocx.Category : throw new AxHost.InvalidActiveXStateException(nameof (Category), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (Category), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.Category = value;
      }
    }

    [DispId(12)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string Topic
    {
      get
      {
        return this.ocx != null ? this.ocx.Topic : throw new AxHost.InvalidActiveXStateException(nameof (Topic), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (Topic), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.Topic = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(13)]
    public virtual string WelcomeMsg
    {
      get
      {
        return this.ocx != null ? this.ocx.WelcomeMsg : throw new AxHost.InvalidActiveXStateException(nameof (WelcomeMsg), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (WelcomeMsg), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.WelcomeMsg = value;
      }
    }

    [DispId(15)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string BaseURL
    {
      get
      {
        return this.ocx != null ? this.ocx.BaseURL : throw new AxHost.InvalidActiveXStateException(nameof (BaseURL), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (BaseURL), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.BaseURL = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(16)]
    [ComAliasName("System.UInt32")]
    public virtual Color InputBorderColor
    {
      get
      {
        return this.ocx != null ? AxHost.GetColorFromOleColor(this.ocx.InputBorderColor) : throw new AxHost.InvalidActiveXStateException(nameof (InputBorderColor), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (InputBorderColor), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.InputBorderColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DispId(17)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string CreateRoom
    {
      get
      {
        return this.ocx != null ? this.ocx.CreateRoom : throw new AxHost.InvalidActiveXStateException(nameof (CreateRoom), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (CreateRoom), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.CreateRoom = value;
      }
    }

    [DispId(19)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string ChatHome
    {
      get
      {
        return this.ocx != null ? this.ocx.ChatHome : throw new AxHost.InvalidActiveXStateException(nameof (ChatHome), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ChatHome), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ChatHome = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(20)]
    public virtual string Locale
    {
      get
      {
        return this.ocx != null ? this.ocx.Locale : throw new AxHost.InvalidActiveXStateException(nameof (Locale), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (Locale), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.Locale = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(21)]
    public virtual string ResDLL
    {
      get
      {
        return this.ocx != null ? this.ocx.ResDLL : throw new AxHost.InvalidActiveXStateException(nameof (ResDLL), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ResDLL), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ResDLL = value;
      }
    }

    [DispId(22)]
    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual Color ButtonTextColor
    {
      get
      {
        return this.ocx != null ? AxHost.GetColorFromOleColor(this.ocx.ButtonTextColor) : throw new AxHost.InvalidActiveXStateException(nameof (ButtonTextColor), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ButtonTextColor), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ButtonTextColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DispId(23)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [ComAliasName("System.UInt32")]
    public virtual Color ButtonBackColor
    {
      get
      {
        return this.ocx != null ? AxHost.GetColorFromOleColor(this.ocx.ButtonBackColor) : throw new AxHost.InvalidActiveXStateException(nameof (ButtonBackColor), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ButtonBackColor), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ButtonBackColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(24)]
    public virtual string PassportTicket
    {
      get
      {
        return this.ocx != null ? this.ocx.PassportTicket : throw new AxHost.InvalidActiveXStateException(nameof (PassportTicket), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (PassportTicket), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.PassportTicket = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(25)]
    public virtual string PassportProfile
    {
      get
      {
        return this.ocx != null ? this.ocx.PassportProfile : throw new AxHost.InvalidActiveXStateException(nameof (PassportProfile), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (PassportProfile), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.PassportProfile = value;
      }
    }

    [DispId(26)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual uint Feature
    {
      get
      {
        return this.ocx != null ? this.ocx.Feature : throw new AxHost.InvalidActiveXStateException(nameof (Feature), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (Feature), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.Feature = value;
      }
    }

    [DispId(27)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string MessageOfTheDay
    {
      get
      {
        return this.ocx != null ? this.ocx.MessageOfTheDay : throw new AxHost.InvalidActiveXStateException(nameof (MessageOfTheDay), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (MessageOfTheDay), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.MessageOfTheDay = value;
      }
    }

    [DispId(28)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string ChannelLanguage
    {
      get
      {
        return this.ocx != null ? this.ocx.ChannelLanguage : throw new AxHost.InvalidActiveXStateException(nameof (ChannelLanguage), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (ChannelLanguage), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.ChannelLanguage = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(29)]
    public virtual string InvitationCode
    {
      get
      {
        return this.ocx != null ? this.ocx.InvitationCode : throw new AxHost.InvalidActiveXStateException(nameof (InvitationCode), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (InvitationCode), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.InvitationCode = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(30)]
    public virtual string NicknameToInvite
    {
      get
      {
        return this.ocx != null ? this.ocx.NicknameToInvite : throw new AxHost.InvalidActiveXStateException(nameof (NicknameToInvite), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (NicknameToInvite), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.NicknameToInvite = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(31)]
    public virtual string MSNREGCookie
    {
      get
      {
        return this.ocx != null ? this.ocx.MSNREGCookie : throw new AxHost.InvalidActiveXStateException(nameof (MSNREGCookie), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (MSNREGCookie), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.MSNREGCookie = value;
      }
    }

    [DispId(32)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string CreationModes
    {
      get
      {
        return this.ocx != null ? this.ocx.CreationModes : throw new AxHost.InvalidActiveXStateException(nameof (CreationModes), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (CreationModes), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.CreationModes = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(33)]
    public virtual string MSNProfile
    {
      get
      {
        return this.ocx != null ? this.ocx.MSNProfile : throw new AxHost.InvalidActiveXStateException(nameof (MSNProfile), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (MSNProfile), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.MSNProfile = value;
      }
    }

    [DispId(34)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string Market
    {
      get
      {
        return this.ocx != null ? this.ocx.Market : throw new AxHost.InvalidActiveXStateException(nameof (Market), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (Market), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.Market = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(35)]
    public virtual string WhisperContent
    {
      get
      {
        return this.ocx != null ? this.ocx.WhisperContent : throw new AxHost.InvalidActiveXStateException(nameof (WhisperContent), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (WhisperContent), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.WhisperContent = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(36)]
    public virtual string UserRole
    {
      get
      {
        return this.ocx != null ? this.ocx.UserRole : throw new AxHost.InvalidActiveXStateException(nameof (UserRole), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (UserRole), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.UserRole = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(37)]
    public virtual string AuditMessage
    {
      get
      {
        return this.ocx != null ? this.ocx.AuditMessage : throw new AxHost.InvalidActiveXStateException(nameof (AuditMessage), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (AuditMessage), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.AuditMessage = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(38)]
    public virtual string SubscriberInfo
    {
      get
      {
        return this.ocx != null ? this.ocx.SubscriberInfo : throw new AxHost.InvalidActiveXStateException(nameof (SubscriberInfo), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (SubscriberInfo), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.SubscriberInfo = value;
      }
    }

    [DispId(39)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string UpsellURL
    {
      get
      {
        return this.ocx != null ? this.ocx.UpsellURL : throw new AxHost.InvalidActiveXStateException(nameof (UpsellURL), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (UpsellURL), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.UpsellURL = value;
      }
    }

    protected override void AttachInterfaces()
    {
      try
      {
        this.ocx = (IChatFrame) this.GetOcx();
      }
      catch (Exception)
      {
      }
    }
  }
}
