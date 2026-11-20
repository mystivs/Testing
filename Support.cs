using System;

public class Support : Archetype
{
    public bool OnCast { get; set; } = false;
    public bool OnAttack { get; set; } = false;
    public bool CanHeal { get; set; } = false;
    public bool OnAllyCast { get; set; } = false;
    public bool OnDeath { get; set; } = false;
    public bool DrawCondition { get; set; } = false;

    public int EffectCondition { get; set; }
    public int AssistPower { get; set; }
    public int AssistHealth { get; set; }

    public string EffectDesc { get; set; } = "";
}
