using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn : MonoBehaviour
{
    //public GameObject[] character;
    [SerializeField]
    public GameObject[] characterPrefabs;
    public GameObject P3;
    public GameObject P4;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("P3") == 1)
        {
            P3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("P4") == 1)
        {
            P4.SetActive(true);
        }
        LoadCharacter();
    }
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LoadCharacter()
    {
        int characterIndex = PlayerPrefs.GetInt("CharacterIndex");
        //Instantiate(characterPrefabs[characterIndex],transform);
    }
}
