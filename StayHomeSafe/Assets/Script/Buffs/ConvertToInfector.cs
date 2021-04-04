using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToInfector : MonoBehaviour
{
    public GameObject citizen;
    public CapsuleCollider collider;
    public bool HaveBuff;
    public ParticleSystem buff;
   
    public float waittime = 7f;
    public bool gasMask;

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
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Infector" && citizen.tag != "Infector" && !gasMask)
        {
            HaveBuff = true;
            citizen.tag = "Infector";
            collider.enabled = !collider.enabled;
            buff.Play();
        }
        else if(other.CompareTag("GasMask"))
        {
            gasMask = true;

            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountDown());
        }
    }

    IEnumerator PowerUpCountDown()
    {
        yield return new WaitForSeconds(waittime);
        gasMask = false;
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