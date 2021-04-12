using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    // Start is called before the first frame update

    private void Awake()
    {
        if (PlayerPrefs.GetInt("P1") == 1)
        {
            P3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("P2") == 1)
        {
            P4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("P3") == 1)
        {
            P3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("P4") == 1)
        {
            P4.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
