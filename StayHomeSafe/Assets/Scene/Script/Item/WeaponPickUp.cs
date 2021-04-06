using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : Interactable
    {
        public WeaponItem weapon;

        public override void Interact(ConvertToInfector convertToInfector)
        {
            base.Interact(convertToInfector);
            PickUpItem(convertToInfector);
        }

        private void PickUpItem(ConvertToInfector convertToInfector)
        {
            PlayerInventory playerInventory;
            AnimatorHandler animatorHandler;

            playerInventory = convertToInfector.GetComponent<PlayerInventory>();
            animatorHandler = convertToInfector.GetComponentInChildren<AnimatorHandler>();

            
            playerInventory.weaponsInventory.Add(weapon);
            Destroy(gameObject);

        }

    }



