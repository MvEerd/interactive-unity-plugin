﻿#if !UNITY_EDITOR_WIN && !UNITY_STANDALONE_WIN && !UNITY_WSA && !UNITY_XBOXONE
namespace Microsoft.Mixer
{
    public enum InteractiveEventType
    {
        Error,

        InteractivityStateChanged,

        ParticipantStateChanged,

        Button,

        Joystick
    }
}
#endif
