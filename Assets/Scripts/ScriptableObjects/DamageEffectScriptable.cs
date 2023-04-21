using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageEffect", menuName = "ScriptableObjects/ActionScriptables/DamageEffect", order = 2)]
public class DamageEffectScriptable : ActionEffectScriptable
{
    public int damage;

    public override void ApplyEffect(PartyDetails user, PartyDetails opponent)
    {
        switch (target)
        {
            case Target.User:
                user.ModifyHealth(damage);
                break;
            case Target.Opponent:
                opponent.ModifyHealth(damage);
                break;
        }
    }
}
