namespace Content.Shared._MACRO.Nutrition.Components;

/// <summary>
/// This component is used to slow down the time to eat food by a specific multiplier
/// </summary>
[RegisterComponent]
public sealed partial class SlowEaterComponent : Component
{
    [DataField]
    public float Multiplier = 1.5f;
}
