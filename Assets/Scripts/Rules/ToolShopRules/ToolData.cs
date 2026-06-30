using UnityEngine;

namespace Rules.ToolShopRules
{
    [System.Serializable]
    public class ToolData
    {
        [Header("Tool Name")]
        private string _toolName;
        
        [Header("Tool Unlock Level")]
        private int _toolUnlockLevel;
        
        [Header("Tool Price")]
        private int _toolPrice;

        public void InitialToolData(string toolName, int toolUnlockLevel, int toolPrice)
        {
            _toolName = toolName;
            _toolUnlockLevel = toolUnlockLevel;
            _toolPrice = toolPrice;
        }

        public string ToolName => _toolName;
        public int ToolUnlockLevel => _toolUnlockLevel;
        public int ToolPrice => _toolPrice;
    }
}