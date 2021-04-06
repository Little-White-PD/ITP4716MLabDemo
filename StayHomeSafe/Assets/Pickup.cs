using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public string name;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inventory = other.gameObject.GetComponent<Inventory>();
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform,false);
                    Destroy(gameObject);

                    if (name == "FaceMask")
                    {
                        inventory.itemName[i] = "FaceMask";

                    }
                    else if (name == "GasMask")
                    {
                        inventory.itemName[i] = "GasMask";

                    }
                    else if (name == "Syringe")
                    {
                        inventory.itemName[i] = "Syringe";
                    }
                    Debug.Log("i = " + i);
                    break;
                }
            }
        }
    }



}
