using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int baseHealth = 100;
    public int baseMana = 50;
    public int baseSpeed = 5;
    public int baseDefense = 10;

    private List<StatModifier> modifiers = new List<StatModifier>();

    public void AddModifier(StatModifier mod)
    {
        modifiers.Add(mod);
        RecalculateStats();
    }

    public void RemoveModifier(StatModifier mod)
    {
        modifiers.Remove(mod);
        RecalculateStats();
    }

    public void AddModifiers(List<StatModifier> mods)
    {
        modifiers.AddRange(mods);
        RecalculateStats();
    }

    public void RemoveModifiers(List<StatModifier> mods)
    {
        foreach (var mod in mods)
        {
            modifiers.Remove(mod);
        }
        RecalculateStats();
    }

    private void RecalculateStats()
    {
        Debug.Log($"Nova Vida Máxima: {GetMaxHealth()} | Mana: {GetMaxMana()} | Defesa: {GetDefense()} | Velocidade: {GetSpeed()}");
    }

    public int GetMaxHealth()
    {
        int modifiedHealth = baseHealth;
        foreach (var mod in modifiers)
        {
            if (mod.type == StatsType.Health)
                modifiedHealth += mod.value;
        }
        return modifiedHealth;
    }

    public int GetMaxMana()
    {
        int modifiedMana = baseMana;
        foreach (var mod in modifiers)
        {
            if (mod.type == StatsType.Mana)
                modifiedMana += mod.value;
        }
        return modifiedMana;
    }

    public int GetDefense()
    {
        int modifiedDefense = baseDefense;
        foreach (var mod in modifiers)
        {
            if (mod.type == StatsType.Defense)
                modifiedDefense += mod.value;
        }
        return modifiedDefense;
    }

    public int GetSpeed()
    {
        int modifiedSpeed = baseSpeed;
        foreach (var mod in modifiers)
        {
            if (mod.type == StatsType.Speed)
                modifiedSpeed += mod.value;
        }
        return modifiedSpeed;
    }
}
