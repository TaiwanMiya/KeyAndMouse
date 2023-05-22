# KeyAndMouse
Provide keyboard and mouse operation and detection, compatible with all windows versions and bit systems. Use dll files to perform event actions.

## Registration Hook Code Example
> Heptad.Dick.WinSystem.KeyboardMouse
```C#
using Heptad.Dick.WinSystem.KeyboardMouse;

#region Global events (detect windows events)
public static IKeyboardMouseEvents g_kmEvents   => Hook.GlobalEvents();
public static IKeyboardEvents g_kEvents         => Hook.GlobalEvents();
public static IMouseEvents g_mEvents            => Hook.GlobalEvents();
#endregion

#region Application events (detect events of this program)
public static IKeyboardMouseEvents a_kmEvents   => Hook.AppEvents();
public static IKeyboardEvents a_kEvents         => Hook.AppEvents();
public static IMouseEvents a_mEvents            => Hook.AppEvents();
#endregion
```

## Hook detection event binding (Keyboard)
> Heptad.Dick.WinSystem.KeyboardMouse
```C#
using Heptad.Dick.WinSystem.KeyboardMouse;

public static void kmEnable_Keyboard(IKeyboardEvents kmEvents)
{
    #region Keyboard events
    kmEvents.KeyDown    += kmEvents_KeyDown;
    kmEvents.KeyUp      += kmEvents_KeyUp;
    kmEvents.KeyPress   += KmEvents_KeyPress;
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
    kmEvents.MouseDown              += kmEvents_MouseDown;
    kmEvents.MouseUp                += kmEvents_MouseUp;
    kmEvents.MouseMove              += KmEvents_MouseMove;
    kmEvents.MouseClick             += KmEvents_MouseClick;
    kmEvents.MouseWheel             += KmEvents_MouseWheel;
    kmEvents.MouseHWheel            += KmEvents_MouseHWheel;
    kmEvents.MouseDragStarted       += KmEvents_MouseDragStarted;
    kmEvents.MouseDoubleClick       += KmEvents_MouseDoubleClick;
    kmEvents.MouseDownExt           += KmEvents_MouseDownExt;
    kmEvents.MouseUpExt             += KmEvents_MouseUpExt;
    kmEvents.MouseMoveExt           += KmEvents_MouseMoveExt;
    kmEvents.MouseWheelExt          += KmEvents_MouseWheelExt;
    kmEvents.MouseHWheelExt         += KmEvents_MouseHWheelExt;
    kmEvents.MouseDragStartedExt    += KmEvents_MouseDragStartedExt;
    kmEvents.MouseDragFinishedExt   += KmEvents_MouseDragFinishedExt;
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

## Key code conversion
- > Heptad.Dick.WinSystem.KeyboardMouse.Code
- > Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
- > System.Windows.Forms
```C#
using Heptad.Dick.WinSystem.KeyboardMouse.Code;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;
using System.Windows.Forms;

public static int ConvertFromKeyCode(Keys keycode, MapType type)
{
    return KeyboardNativeMethods.MapVirtualKey((int)keycode, (int)type);
}
```

## Keyboard scripting
> Heptad.Dick.WinSystem.KeyboardMouse.Code
> Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
```C#
using Heptad.Dick.WinSystem.KeyboardMouse.Code;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;
using System.Windows.Forms;

public static void KeyDown(Keys keycode, byte Scancode = 0)
{
    KeyboardScript.keybd_event((int)keycode, Scancode, (int)keyFlags.KEYEVENTF_KEYDOWN, 0);
}

public static void KeyUp(Keys keycode, byte Scancode = 0)
{
    KeyboardScript.keybd_event((int)keycode, Scancode, (int)keyFlags.KEYEVENTF_KEYUP, 0);
}
```

## Mouse scripting
> Heptad.Dick.WinSystem.KeyboardMouse.Code
> Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
```C#
using Heptad.Dick.WinSystem.KeyboardMouse.Code;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;
using System.Windows.Forms;

public static void MouseDown(MouseButtons mouseButtons)
{
    switch (mouseButtons)
    {
        case MouseButtons.Left:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            break;
        case MouseButtons.Right:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            break;
        case MouseButtons.Middle:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
            break;
        case MouseButtons.XButton1:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_XDOWN, 0, 0, 0, 0);
            break;
        case MouseButtons.XButton2:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_XDOWN, 0, 0, 0, 0);
            break;
    }
}

public static void MouseUp(MouseButtons mouseButtons)
{
    switch (mouseButtons)
    {
        case MouseButtons.Left:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            break;
        case MouseButtons.Right:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            break;
        case MouseButtons.Middle:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
            break;
        case MouseButtons.XButton1:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_XUP, 0, 0, 0, 0);
            break;
        case MouseButtons.XButton2:
            MouseScript.mouse_event(MouseCode.MOUSEEVENTF_XUP, 0, 0, 0, 0);
            break;
    }
}

public static void MouseMove(int x, int y)
{
    MouseScript.SetCursorPos(x, y);
}

public static void MouseWheel(int delta)
{
    MouseScript.mouse_event(MouseCode.MOUSEEVENTF_WHEEL, 0, 0, delta, 0);
}

public static void MouseHWheel(int delta)
{
    MouseScript.mouse_event(MouseCode.MOUSEEVENTF_HWHEEL, 0, 0, delta, 0);
}
```
