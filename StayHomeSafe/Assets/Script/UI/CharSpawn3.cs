using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn3 : MonoBehaviour
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
        int characterIndex3 = PlayerPrefs.GetInt("CharacterIndex3");
        Instantiate(characterPrefabs[characterIndex3], transform);
    }
}