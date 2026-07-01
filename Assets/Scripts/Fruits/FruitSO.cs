using UnityEngine;
using UnityEngine.UI;

namespace Fruits
{
    [CreateAssetMenu(fileName = "Fruit", menuName = "ScriptableObjects/Fruit")]
    public class FruitSO : ScriptableObject
    {
        [Header("Fruit ID")]
        [SerializeField] private string fruitId;
        
        [Header("Fruit Image Attribute")]
        [SerializeField] private Image fruitImage;
        
        [Header("Seed Price Attribute")]
        [Range(1, 30)]
        [SerializeField] private int seedUnitPrice;

        [Header("Fruit Grow Attribute")]
        [Range(1, 60)]
        [SerializeField] private int fruitGrowCycle;

        [Header("Fruit Sell Price Attribute")]
        [Range(1, 50)]
        [SerializeField] private int fruitSellUnitPrice;
        
        [Header("Fruit Sell Exp Attribute")]
        [Range(1, 50)]
        [SerializeField] private int fruitSellUnitExp;
        
        [Header("Fruit Unlock Level Attribute")]
        [Range(1, 10)]
        [SerializeField] private int fruitUnlockLevel;
        
        [Header("Fruit Harvest Count Down Attribute")]
        [Range(1, 60)]
        [SerializeField] private int fruitharvestCount;
        
        [Header("Fruit Pest Fail Deduct Coin Attribute")]
        [Range(1, 50)]
        [SerializeField] private int fruitpestFailDeductCoin;
    }
}