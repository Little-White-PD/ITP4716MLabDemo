using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class WeaponHolderSlot : MonoBehaviour
    {
        public Transform parentOverride;
        public bool isLLeftHandSlot;
        public bool isRightHandSlot;

        public GameObject currentWeaponMode;

        public void UnloadWeapon()
        {
            if(currentWeaponMode !=null)
            {
                currentWeaponMode.SetActive(false);
            }
        }

        public void UnloadWeaponAndDestroy()
        {
            if(currentWeaponMode != null)
            {
                Destroy(currentWeaponMode);
            }
        }
        public void LoadWeaponModel(WeaponItem weaponItem)
        {

            UnloadWeaponAndDestroy();

            if(weaponItem ==null)
            {
                UnloadWeapon();
                return;
            }

            GameObject model = Instantiate(weaponItem.modelPrefab) as GameObject;
            if(model != null)
            {
                if(parentOverride != null)
                {
                    model.transform.parent = parentOverride;
                }
                else
                {
                    model.transform.parent = transform;
                }

                model.transform.localPosition = Vector3.zero;
                model.transform.localRotation = Quaternion.identity;
                model.transform.localScale = Vector3.one;
            }

            currentWeaponMode = model;
        }
    }
}
