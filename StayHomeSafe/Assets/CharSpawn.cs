using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn : MonoBehaviour
{
    //public GameObject[] character;
    [SerializeField]
    public GameObject[] characterPrefabs;

    private void Awake()
    {
        
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
        Instantiate(characterPrefabs[characterIndex],transform);
    }
}
