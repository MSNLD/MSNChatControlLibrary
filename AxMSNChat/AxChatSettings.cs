using MSNChat;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AxMSNChat
{
  [AxHost.Clsid("{fa980e7e-9e44-4d2f-b3c2-9a5be42525f8}")]
  [DesignTimeVisible(true)]
  public class AxChatSettings : AxHost
  {
    private IChatSettings ocx;
    public event EventHandler ControlReady;

    public AxChatSettings()
      : base("fa980e7e-9e44-4d2f-b3c2-9a5be42525f8")
    {
    }

    [ComAliasName("System.UInt32")]
    [DispId(-501)]
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

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [DispId(-513)]
    public override Color ForeColor
    {
      get
      {
        return this.ocx != null && this.PropsValid() ? AxHost.GetColorFromOleColor(this.ocx.ForeColor) : base.ForeColor;
      }
      set
      {
        base.ForeColor = value;
        if (this.ocx == null)
          return;
        this.ocx.ForeColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DispId(1)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string RedirectURL
    {
      get
      {
        return this.ocx != null ? this.ocx.RedirectURL : throw new AxHost.InvalidActiveXStateException(nameof (RedirectURL), AxHost.ActiveXInvokeKind.PropertyGet);
      }
      set
      {
        if (this.ocx == null)
          throw new AxHost.InvalidActiveXStateException(nameof (RedirectURL), AxHost.ActiveXInvokeKind.PropertySet);
        this.ocx.RedirectURL = value;
      }
    }

    [DispId(2)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

    protected override void AttachInterfaces()
    {
      try
      {
        base.AttachInterfaces();
        this.ocx = (IChatSettings) this.GetOcx();
        ControlReady?.Invoke(this, EventArgs.Empty);
      }
      catch (Exception)
      {
      }
    }
  }
}
