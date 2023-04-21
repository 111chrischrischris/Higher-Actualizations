using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Target
{
    User,
    Opponent
}

public class ActionEffectScriptable : ScriptableObject
{
    public Target target;

    public virtual void ApplyEffect(PartyDetails user, PartyDetails opponent)
    {
        
    }
}
