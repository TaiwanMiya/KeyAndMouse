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

## Hook detection event binding (Keyboard)
> Heptad.Dick.WinSystem.KeyboardMouse
```C#
using Heptad.Dick.WinSystem.KeyboardMouse;

private void kmEnable(IKeyboardEvents kmEvents)
{
    #region Keyboard events
    kmEvents.KeyDown += kmEvents_KeyDown;
    kmEvents.KeyUp += kmEvents_KeyUp;
    kmEvents.KeyPress += KmEvents_KeyPress;
    kmEvents.KeyDownTxt += KmEvents_KeyDownTxt;
    #endregion
}

private void kmEvents_KeyDown(object sender, KeyEventArgs e)
{
    // code when the event occurs
}

private void kmEvents_KeyUp(object sender, KeyEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_KeyDownTxt(object sender, KeyDownTxtEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_KeyPress(object sender, KeyPressEventArgs e)
{
    // code when the event occurs
}
