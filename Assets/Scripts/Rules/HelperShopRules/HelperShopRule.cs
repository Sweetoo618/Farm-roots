using System;
using UnityEngine;

namespace Rules.HelperShopRules
{
    public class HelperShopRule : MonoBehaviour
    {
        public HelperData firstHelperData;
        public HelperData secondHelperData;

        private void Awake()
        {
            firstHelperData = new HelperData();
            firstHelperData.InitialHelperData("农夫一号", 4, 80, 0.1f);
            secondHelperData = new HelperData();
            secondHelperData.InitialHelperData("农夫二号", 6, 150, 0.2f);
        }
    }
}