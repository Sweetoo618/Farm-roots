using System;
using Farmer;
using UnityEngine;

namespace UI.CharacterSwitch
{
    public class CharacterDisplay : MonoBehaviour
    {
        private int _currentFarmerHaveHelperNumber;
        private FarmerAttribute _farmerAttribute;

        private void Awake()
        {
            _farmerAttribute = FindObjectOfType<FarmerAttribute>();
            _currentFarmerHaveHelperNumber = _farmerAttribute.GetFarmerHaveHelperNumber();
        }

        private void Update()
        {
            if (_farmerAttribute == null) return;
            int newHelperNumber = _farmerAttribute.GetFarmerHaveHelperNumber();
            if (newHelperNumber != _currentFarmerHaveHelperNumber)
            {
                _currentFarmerHaveHelperNumber = newHelperNumber;
                CharacterDisplayUpdate();
            }
        }

        private void CharacterDisplayUpdate()
        {
            
        }
    }
}