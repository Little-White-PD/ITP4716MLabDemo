using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn1 : MonoBehaviour
{
    public GameObject[] items;
    public string item;
    public int nuber;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != item && other.tag != "Player")
            Instantiate(items[nuber], transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
    }
}
