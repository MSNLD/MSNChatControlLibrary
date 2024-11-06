# MSNChatControlLibrary

[![MSBuild](https://github.com/realJoshByrnes/MSNChatControlLibrary/actions/workflows/msbuild.yml/badge.svg)](https://github.com/realJoshByrnes/MSNChatControlLibrary/actions/workflows/msbuild.yml)

## Overview

The `MSNChatControlLibrary` is a .NET library that provides user controls for integrating MSN Chat functionalities into your Windows Forms applications. The library includes two main user controls:

- `MSNChatControl`: A user control for displaying and interacting with MSN Chat frames.
- `ChatSettingsControl`: A user control for configuring chat settings.

## Features

- **ChatSettingsControl**:
  - Allows configuration of chat settings such as `BackColor`, `ForeColor`, `RedirectURL`, and `ResDLL`.
  - Automatically updates the designer when properties are changed.

- **MSNChatControl**:
  - Integrates `AxMSNChatFrame` to provide a full-featured chat interface.
  - Exposes various properties for customization, including `RoomName`, `NickName`, `Server`, `ChatMode`, and many more.
  - Ensures properties are properly set both at design time and runtime.

## Installation

To use the `MSNChatControlLibrary` in your project, follow these steps:

1. Clone the repository:
   
````
   git clone https://github.com/realJoshByrnes/MSNChatControlLibrary.git
````

2. Add the project to your solution in Visual Studio.

3. Add a reference to the `MSNChatControlLibrary` project in your Windows Forms application.

## Usage

### MSNChatControl

To use the `MSNChatControl`, drag and drop it from the toolbox onto your form. You can then configure its properties either through the Properties window or programmatically.

````
var msnChatControl = new MSNChatControl
{
    BaseURL = "http://example.com",
    NickName = "User123",
    RoomName = "General",
    Server = "chat.example.com"
};
this.Controls.Add(msnChatControl);
````

### ChatSettingsControl

To use the `ChatSettingsControl`, drag and drop it from the toolbox onto your form. You can then configure its properties either through the Properties window or programmatically.

````
var chatSettingsControl = new ChatSettingsControl
{
    BackColor = Color.White,
    ForeColor = Color.FromArgb(51, 51, 153),
    RedirectURL = "http://example.com",
    ResDLL = "path/to/res.dll"
};
this.Controls.Add(chatSettingsControl);
````

## Contributing

Contributions are welcome! Please open an issue or submit a pull request if you have any improvements or bug fixes.

## License

This project is licensed under the GPLv3 License. See the [LICENSE](LICENSE) file for details.
