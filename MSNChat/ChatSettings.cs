using System.Runtime.InteropServices;

namespace MSNChat
{
  [Guid("D5EF4299-12F1-474D-98C5-3C658FD2E343")]
  [CoClass(typeof (ChatSettingsClass))]
  [ComImport]
  public interface ChatSettings : IChatSettings
  {
  }
}
