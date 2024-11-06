using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat
{
  [TypeLibType(TypeLibTypeFlags.FCanCreate)]
  [Guid("FA980E7E-9E44-4D2F-B3C2-9A5BE42525F8")]
  [ClassInterface(ClassInterfaceType.None)]
  [ComImport]
  public class ChatSettingsClass : IChatSettings, ChatSettings
  {
    [DispId(-501)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint BackColor { [DispId(-501), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("stdole.OLE_COLOR"), In] set; [DispId(-501), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_COLOR")] get; }

    [DispId(-513)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint ForeColor { [DispId(-513), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("stdole.OLE_COLOR"), In] set; [DispId(-513), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_COLOR")] get; }

    [DispId(1)]
    public virtual extern string RedirectURL { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(2)]
    public virtual extern string ResDLL { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }
  }
}
