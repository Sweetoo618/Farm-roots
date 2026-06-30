using UnityEngine;

namespace Rules.ToolShopRules
{
    public class ToolShopRule : MonoBehaviour
    {
        public ToolData seederData;
        public ToolData harvesterData;

        private void Awake()
        {
            seederData = new ToolData();
            seederData.InitialToolData("播种机", 3, 80);

            harvesterData = new ToolData();
            harvesterData.InitialToolData("收割机", 7, 180);
        }
    }
}