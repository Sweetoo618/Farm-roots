using UnityEngine;

namespace Rules.HelperShopRules
{
    [System.Serializable]
    public class HelperData
    {
        [Header("Helper Name")]
        private string _helperName;
        
        [Header("Helper UnlockLevel")]
        private int _helperUnlockLevel;
        
        [Header("Helper Price")]
        private int _helperPrice;
        
        [Header("Helper Special Effect")]
        [Range(0, 1)]
        private float _totalFruitGrowSpeedUpPercent;

        public void InitialHelperData(string helperName, int helperUnlockLevel, int helperPrice,
            float totalFruitGrowSpeedUpPercent)
        {
            _helperName = helperName;
            _helperUnlockLevel = helperUnlockLevel;
            _helperPrice = helperPrice;
            _totalFruitGrowSpeedUpPercent = totalFruitGrowSpeedUpPercent;
        }
        
        public string HelperName => _helperName;
        public int HelperUnlockLevel => _helperUnlockLevel;
        public int HelperPrice => _helperPrice;
        public float TotalFruitGrowSpeedUpPercent => _totalFruitGrowSpeedUpPercent;
    }
}