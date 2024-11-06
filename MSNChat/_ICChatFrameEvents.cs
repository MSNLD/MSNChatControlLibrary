using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChat
{
  [Guid("5EEB8014-53B2-448B-9F3B-C553424832E1")]
  [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  [TypeLibType(TypeLibTypeFlags.FDispatchable)]
  [ComImport]
  public interface _ICChatFrameEvents
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnRedirect([MarshalAs(UnmanagedType.BStr), In] string strUrl);
  }
}
