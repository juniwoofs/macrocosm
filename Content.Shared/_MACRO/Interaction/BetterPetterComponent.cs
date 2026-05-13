namespace Content.Shared.Interaction;

/// <summary>
///     Allows any entity with this component to have a higher success rate when petting mobs with <see cref="InteractionPopupComponent"/>.
/// </summary>
[RegisterComponent]
public sealed partial class BetterPetterComponent : Component
{
    /// <summary>
    ///     Multiplier of the chance to successfully pet a mob.
    /// </summary>
    [DataField]
    public float Multiplier = 1;
}
