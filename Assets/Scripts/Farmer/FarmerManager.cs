using UnityEngine;

namespace Farmer
{
    public class FarmerManager : MonoBehaviour
    {
        private FarmerController _farmerController;
        private FarmerAttribute _farmerAttribute;
        private FarmerAnimationController _farmerAnimationController;

        private void Awake()
        {
            _farmerController = GetComponent<FarmerController>();
            _farmerAttribute = GetComponent<FarmerAttribute>();
            _farmerAnimationController = GetComponent<FarmerAnimationController>();
        }

        private void Start()
        {
            _farmerAttribute.InitializeFarmerCoinNumber();
        }

        private void FixedUpdate()
        {
            _farmerAnimationController.FarmerMove(_farmerController.CurrentMoveSpeed);
        }
    }
}
