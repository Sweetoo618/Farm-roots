using System;
using Farmer;
using UnityEngine;

namespace UI.CharacterSwitch
{
    public class CharacterSwitch : MonoBehaviour
    {
        private int _currentFarmerHaveHelperNumber;

        private void Awake()
        {
            _currentFarmerHaveHelperNumber = 
                GetComponent<FarmerAttribute>().GetFarmerHaveHelperNumber();
        }

        private void UpDate()
        {
            
        }
    }
}