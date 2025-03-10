using Robust.Shared.GameStates;

namespace Content.Shared.Heretic;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class HereticCombatMarkComponent : Component
{
    [DataField, AutoNetworkedField] public string Path = "Blade";

    [DataField] public float DisappearTime = 5f;
    public TimeSpan Timer = TimeSpan.Zero;
}
