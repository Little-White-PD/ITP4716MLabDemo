using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOJ : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(Des());
    }

    IEnumerator Des()
    {
        yield return new WaitForSeconds(20);
        Destroy(gameObject);
    }
}
