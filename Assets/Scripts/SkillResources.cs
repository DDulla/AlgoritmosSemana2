using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/SkillResources", order = 2)]
public class SkillResources : ScriptableObject
{
    [SerializeField] private List<Skill> skills = new List<Skill>();

    public List<Skill> Skills => skills;

    public Skill GetSkillByName(string skillName)
    {
        return skills.Find(skill => skill.SkillName == skillName);
    }
}