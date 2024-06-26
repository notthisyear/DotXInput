﻿using System;

namespace DotXInput.GamepadInput.XInput.Enumerations
{
    // Note: Bits that are set but not defined above are reserved, and their state is undefined.
    [Flags]
    internal enum XInputGamepadDigitalButtonFlag : ushort
    {
        XINPUT_GAMEPAD_DPAD_UP = 0x0001,

        XINPUT_GAMEPAD_DPAD_DOWN = 0x0002,

        XINPUT_GAMEPAD_DPAD_LEFT = 0x0004,

        XINPUT_GAMEPAD_DPAD_RIGHT = 0x0008,

        XINPUT_GAMEPAD_START = 0x0010,

        XINPUT_GAMEPAD_BACK = 0x0020,

        XINPUT_GAMEPAD_LEFT_THUMB = 0x0040,

        XINPUT_GAMEPAD_RIGHT_THUMB = 0x0080,

        XINPUT_GAMEPAD_LEFT_SHOULDER = 0x0100,

        XINPUT_GAMEPAD_RIGHT_SHOULDER = 0x0200,

        XINPUT_GAMEPAD_A = 0x1000,

        XINPUT_GAMEPAD_B = 0x2000,

        XINPUT_GAMEPAD_X = 0x4000,

        XINPUT_GAMEPAD_Y = 0x8000,
    }
}
