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
```

## Hook detection event binding (Keyboard)
> Heptad.Dick.WinSystem.KeyboardMouse
```C#
using Heptad.Dick.WinSystem.KeyboardMouse;

public static void kmEnable_Keyboard(IKeyboardEvents kmEvents)
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

private void KmEvents_KeyPress(object sender, KeyPressEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_KeyDownTxt(object sender, KeyDownTxtEventArgs e)
{
    // code when the event occurs
}
```
## Hook detection event binding (Mouse)
> Heptad.Dick.WinSystem.KeyboardMouse
```C#
using Heptad.Dick.WinSystem.KeyboardMouse;

public static void kmEnable_Mouse(IMouseEvents kmEvents)
{
    #region Mouse event
    kmEvents.MouseDown += kmEvents_MouseDown;
    kmEvents.MouseUp += kmEvents_MouseUp;
    kmEvents.MouseMove += KmEvents_MouseMove;
    kmEvents.MouseClick += KmEvents_MouseClick;
    kmEvents.MouseWheel += KmEvents_MouseWheel;
    kmEvents.MouseHWheel += KmEvents_MouseHWheel;
    kmEvents.MouseDragStarted += KmEvents_MouseDragStarted;
    kmEvents.MouseDoubleClick += KmEvents_MouseDoubleClick;
    kmEvents.MouseDownExt += KmEvents_MouseDownExt;
    kmEvents.MouseUpExt += KmEvents_MouseUpExt;
    kmEvents.MouseMoveExt += KmEvents_MouseMoveExt;
    kmEvents.MouseWheelExt += KmEvents_MouseWheelExt;
    kmEvents.MouseHWheelExt += KmEvents_MouseHWheelExt;
    kmEvents.MouseDragStartedExt += KmEvents_MouseDragStartedExt;
    kmEvents.MouseDragFinishedExt += KmEvents_MouseDragFinishedExt;
    #endregion
}

private void kmEvents_MouseDown(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void kmEvents_MouseUp(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseMove(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseClick(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseWheel(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseHWheel(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseDoubleClick(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseDragStarted(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseDragFinished(object sender, MouseEventArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseDownExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseUpExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseMoveExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseWheelExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseHWheelExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseDragStartedExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}

private void KmEvents_MouseDragFinishedExt(object sender, MouseEventExtArgs e)
{
    // code when the event occurs
}
```
