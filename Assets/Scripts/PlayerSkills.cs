using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    [SerializeField] private SkillManager skillManager;
    [SerializeField] private List<Skill> unlockedSkills = new List<Skill>();
    [SerializeField] private int skillPoints = 1;
    [SerializeField] private int playerLevel = 1;

    public void TryUnlockSkill(Skill skill)
    {
        if (unlockedSkills.Contains(skill))
        {
            Debug.Log("La habilidad " + skill.SkillName + " ya está desbloqueada.");
            return; 
        }

        if (skillManager.CanUnlockSkill(skill, unlockedSkills, playerLevel) && skillPoints >= skill.Cost)
        {
            skillPoints -= skill.Cost; 
            skillManager.UnlockSkill(skill, unlockedSkills);
        }
        else
        {
            Debug.Log("No puedes desbloquear " + skill.SkillName + ". Revisa los puntos, requisitos o nivel.");
        }
    }

    public void AddExperience()
    {
        playerLevel++;
        skillPoints++;
        Debug.Log("Subiste al nivel " + playerLevel + ". Puntos de habilidad disponibles: " + skillPoints + ".");
    }

    public void ResetPlayer()
    {
        playerLevel = 1;
        skillPoints = 1;
        unlockedSkills.Clear();
        Debug.Log("Nivel y habilidades reiniciados.");
    }
}