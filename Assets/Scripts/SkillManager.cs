using System.Collections.Generic;
using Mark;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public bool CanUnlockSkill(Skill skill, List<Skill> unlockedSkills, int playerLevel)
    {
        if (playerLevel < skill.LevelRequirement)
        {
            Debug.Log("Nivel insuficiente para desbloquear " + skill.SkillName + ". Requiere nivel " + skill.LevelRequirement + ".");
            return false;
        }

        if (!GameUtils.AllPrerequisitesUnlocked(skill.Prerequisites, unlockedSkills))
        {
            Debug.Log("Faltan requisitos para desbloquear " + skill.SkillName + ".");
            return false;
        }

        return true;
    }

    public void UnlockSkill(Skill skill, List<Skill> unlockedSkills)
    {
        if (!unlockedSkills.Contains(skill))
        {
            unlockedSkills.Add(skill);
            Debug.Log("Habilidad " + skill.SkillName + " desbloqueada! Descripcion: " + skill.Description + ".");
        }
    }
}