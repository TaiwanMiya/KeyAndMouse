# KeyAndMouse
Provide keyboard and mouse operation and detection, compatible with all windows versions and bit systems. Use dll files to perform event actions.

## Registration Hook Code Example
> Heptad.Dick.WinSystem.KeyboardMouse
```C#

using Heptad.Dick.WinSystem.KeyboardMouse;

/// <summary>
///     Call keyboard and mouse events (global, can be detected on this windows operating system)
/// </summary>
public static IKeyboardMouseEvents kmEvents => Hook.GlobalEvents();
