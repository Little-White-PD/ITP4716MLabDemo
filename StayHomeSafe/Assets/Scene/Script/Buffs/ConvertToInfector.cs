using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConvertToInfector : MonoBehaviour
{
    public GameObject citizen;
    public CapsuleCollider collider;
    public bool HaveBuff;
    public ParticleSystem buff;
   
    public float gasMaskTime = 20f;
    public float MaskTime = 5f;


    public float protectTime;
    public bool protect;

    public WeaponItem weapon;
    PlayerInventory playerInventory;


    public void Start()
    {
        if (citizen.tag == "Infector")
        {
            HaveBuff = true;
            collider.enabled = !collider.enabled;
            buff.Play();
        }
    }

    public void Update()
    {
        if (HaveBuff == false)
        {
            buff.Stop();
            ColliderOpen();
        }
        if (protectTime > 0)
        {
            protect = true;
            protectTime -= Time.deltaTime;
        }
        else protect = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Infector" && citizen.tag != "Infector" && !protect)
        {
            if (other.GetComponent<ConvertToInfector>().protect == false)
            {
                HaveBuff = true;
                citizen.tag = "Infector";
                collider.enabled = !collider.enabled;
                buff.Play();
            }
        }
        else if(other.CompareTag("GasMask"))
        {

            protectTime += gasMaskTime;
            
            Destroy(other.gameObject);
            
            
            
        }
        else if (other.CompareTag("Mask"))
        {
            protectTime += MaskTime;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Syringe"))
        {
            HaveBuff = false;
            Destroy(other.gameObject);
        }
    }


    void ColliderOpen()
    {
        if (citizen.tag == "Infector")
        {
            collider.enabled = true;
            citizen.tag = "Citizens";
        }
    }
}

