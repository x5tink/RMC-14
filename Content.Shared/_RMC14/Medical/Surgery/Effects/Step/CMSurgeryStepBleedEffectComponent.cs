using Robust.Shared.GameStates;
using Content.Shared.Damage;

namespace Content.Shared._RMC14.Medical.Surgery.Effects.Step;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedCMSurgerySystem))]
public sealed partial class CMSurgeryStepBleedEffectComponent : Component
{
    [DataField, AutoNetworkedField]
    public int Damage;

    [DataField, AutoNetworkedField]
    public DamageSpecifier DirectDamage = new();

    [DataField, AutoNetworkedField]
    public bool OnSuccess = true;

    [DataField, AutoNetworkedField]
    public bool OnFailure;
}
