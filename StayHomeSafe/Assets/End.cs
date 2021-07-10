using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public ConvertToInfector[] player;
    public GameObject[] end;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player[0].skillTime > 0)
        {
            end[0].SetActive(false);
            end[1].SetActive(true);
        }
        if (player[1].skillTime > 0)
        {
            end[0].SetActive(false);
            end[1].SetActive(true);
        }
        if (player[2].skillTime > 0)
        {
            end[0].SetActive(false);
            end[1].SetActive(true);
        }
        if (player[3].skillTime > 0)
        {
            end[0].SetActive(false);
            end[1].SetActive(true);
        }
    }
}
