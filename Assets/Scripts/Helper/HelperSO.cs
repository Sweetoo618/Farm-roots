using UnityEngine;
using UnityEngine.UI;

namespace Helper
{
    [CreateAssetMenu(fileName = "Helper", menuName = "ScriptableObjects/Helper")]
    public class HelperSO : ScriptableObject
    {
        [Header("Helper Name")]
        [SerializeField] private string helperName;
        
        [Header("Helper Description")]
        [SerializeField] private string helperDescription;

        [Header("Helper Sex")]
        [SerializeField] private bool isMaleHelper;
        
        [Header("Helper Image")]
        [SerializeField] private Image helperImage;
        
        [Header("Helper UnlockLevel")]
        [Range(0, 10)]
        [SerializeField] private int helperUnlockLevel;
        
        [Header("Helper Price")]
        [Range(0, 200)]
        [SerializeField] private int helperPrice;
        
        [Header("Helper Move Speed")]
        [Range(0, 10)]
        [SerializeField] private int helperMoveSpeed;
    }
}