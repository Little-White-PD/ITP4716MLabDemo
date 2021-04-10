using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Inventory inventory;
    public ConvertToInfector convertToInfector;
    public Button button;
    public KeyCode key;
    public int i;


    private void FixedUpdate()
    {
        if (Input.GetKeyDown(key))
        {
            button.onClick.Invoke();
        }

        if (transform.childCount <= 0)
        {
            if (inventory.itemName[i] == "GasMask")
            {
                convertToInfector.gasMask = false;
                convertToInfector.protectTime += convertToInfector.gasMaskTime;
                inventory.isFull[i] = false;
                inventory.itemName[i] = null;
            }

            if (inventory.itemName[i] == "FaceMask")
            {
                convertToInfector.mask = false;
                convertToInfector.protectTime += convertToInfector.maskTime;
                inventory.isFull[i] = false;
                inventory.itemName[i] = null;
            }
            if (inventory.itemName[i] == "Syringe")
            {

                convertToInfector.useSyringe = true;
                    inventory.isFull[i] = false;
                    inventory.itemName[i] = null;
                
               
            }

        }


        

    }

   /*private void FixedUpdate()
    {
        if (Input.GetKeyDown(key))
        {
            button.onClick.Invoke();
        }
    }*/

    public void DropItem()
    {
        
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
