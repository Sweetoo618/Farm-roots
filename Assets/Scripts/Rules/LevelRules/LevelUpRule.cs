using Farmer;
using Rules.LevelRules;
using UnityEngine;

namespace Rules
{
    public class LevelUpRule : MonoBehaviour
    {
        
        public void LevelUpRuleFunction()
        {
            int currentFarmerLevel = GetComponent<FarmerAttribute>().GetFarmerLevel();
            string levelKey = $"Level{currentFarmerLevel}ToLevel{currentFarmerLevel + 1}";
            if (!LevelConfig.LevelUpExpConfig.TryGetValue(levelKey, out int currentFarmerCheckExpVal)) return;
            int currentFarmerExpVal = GetComponent<FarmerAttribute>().GetFarmerExpVal();
            if (CheckCanLevelUp(currentFarmerExpVal, currentFarmerCheckExpVal))
            {
                GetComponent<FarmerAttribute>().AddFarmerLevel();
            }
        }

        private bool CheckCanLevelUp(int currentFarmerExpVal, int currentFarmerCheckExpVal)
        {
            return currentFarmerExpVal >= currentFarmerCheckExpVal;
        }
    }
}