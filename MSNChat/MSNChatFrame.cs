using System.Runtime.InteropServices;

namespace MSNChat
{
  [CoClass(typeof (MSNChatFrameClass))]
  [Guid("125E64FA-3304-4BB9-A756-D0D44CC8CD7D")]
  [ComImport]
  public interface MSNChatFrame : IChatFrame
  {
  }
}
