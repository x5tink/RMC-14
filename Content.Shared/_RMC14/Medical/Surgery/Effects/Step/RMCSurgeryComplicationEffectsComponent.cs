using Robust.Shared.GameStates;
using Content.Shared.Damage;

namespace Content.Shared._RMC14.Medical.Surgery.Effects.Step;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedCMSurgerySystem))]
public sealed partial class RMCSurgeryComplicationEffectsComponent : Component
{
    [DataField, AutoNetworkedField]
    public int? SuccessBleedDamage;

    [DataField, AutoNetworkedField]
    public int? FailureBleedDamage;

    [DataField, AutoNetworkedField]
    public DamageSpecifier? SuccessDirectDamage;

    [DataField, AutoNetworkedField]
    public DamageSpecifier? FailureDirectDamage;
}