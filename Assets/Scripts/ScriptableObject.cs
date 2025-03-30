using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/Skill", order = 1)]
public class Skill : ScriptableObject
{
    [SerializeField] private string skillName;
    [SerializeField] private string description;
    [SerializeField] private int levelRequirement;
    [SerializeField] private int cost;
    [SerializeField] private List<Skill> prerequisites;

    public string SkillName => skillName;
    public string Description => description;
    public int LevelRequirement => levelRequirement;
    public int Cost => cost;
    public List<Skill> Prerequisites => prerequisites;
}