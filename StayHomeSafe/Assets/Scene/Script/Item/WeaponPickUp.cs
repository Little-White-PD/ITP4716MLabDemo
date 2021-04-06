using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : Interactable
    {
        public WeaponItem weapon;

        public override void Interact(PlayerController playerController)
        {
            base.Interact(playerController);
        }

        private void PickUpItem(PlayerController playerController)
        {
            PlayerInventory playerInventory;
            AnimatorHandler animatorHandler;

            playerInventory = playerController.GetComponent<PlayerInventory>();
            animatorHandler = playerController.GetComponentInChildren<AnimatorHandler>();

            
            playerInventory.weaponsInventory.Add(weapon);
            Destroy(gameObject);

        }

    }



