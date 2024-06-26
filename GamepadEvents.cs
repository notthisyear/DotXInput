﻿using DotXInput.GamepadInput;

namespace DotXInput.Input.GamepadInput
{
    public abstract record InputEvent(InputEventType Type);

    public record ButtonEvent(GamepadDigitalInput Button, GamepadDigitalInputState State) : InputEvent(InputEventType.Button);

    public record TriggerEvent(GamepadAnalogInput Trigger, float Value) : InputEvent(InputEventType.Trigger);

    public record StickEvent(GamepadAnalogInput Stick, float XValue, float YValue) : InputEvent(InputEventType.Stick);
}
