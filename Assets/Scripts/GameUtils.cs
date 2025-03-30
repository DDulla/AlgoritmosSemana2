using System;
using System.Collections.Generic;

namespace Mark
{
    public static class GameUtils
    {
        public static void ApplyToAll<T>(List<T> list, Action<T> action)
        {
            if (list == null || list.Count == 0) return;

            foreach (var item in list)
            {
                action(item);
            }
        }

        public static bool AllPrerequisitesUnlocked(List<Skill> prerequisites, List<Skill> unlockedSkills)
        {
            foreach (var prerequisite in prerequisites)
            {
                if (!unlockedSkills.Contains(prerequisite))
                {
                    return false;
                }
            }
            return true;
        }
    }
}