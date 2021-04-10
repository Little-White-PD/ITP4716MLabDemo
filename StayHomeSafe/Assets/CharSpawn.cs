using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn : MonoBehaviour
{
    public GameObject[] character;
    private void Awake()
    {
        Instantiate(character[0],transform);
    }
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
