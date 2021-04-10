using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    private ConvertToInfector playerBeg;
    public GameObject itemButton;
    public string name;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inventory = other.gameObject.GetComponent<Inventory>();
            playerBeg = other.gameObject.GetComponent<ConvertToInfector>();
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    if (playerBeg.mask == false || playerBeg.gasMask == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton, inventory.slots[i].transform, false);
                        Destroy(gameObject);

                        if (name == "FaceMask" )
                        {
                            inventory.itemName[i] = "FaceMask";
                            playerBeg.mask = true;

                        }
                        if (name == "GasMask")
                        {
                            inventory.itemName[i] = "GasMask";
                            playerBeg.gasMask = true;

                        }
                        if (name == "Syringe")
                        {
                            inventory.itemName[i] = "Syringe";
                            inventory.isFull[i] = true;
                        }

                            break;
                    }
                    else if(name == "Syringe")
                    {                      
                            
                        inventory.isFull[i] = true;
                        Instantiate(itemButton, inventory.slots[i].transform, false);
                        Destroy(gameObject);
                        inventory.itemName[i] = "Syringe";
                        
                    }
                    break;
                }
            }
        }
    }



}
