using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn4 : MonoBehaviour
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
        int characterIndex4 = PlayerPrefs.GetInt("CharacterIndex4");
        Instantiate(characterPrefabs[characterIndex4], transform);
    }
}