using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn2 : MonoBehaviour
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
        int characterIndex2 = PlayerPrefs.GetInt("CharacterIndex2");
        Instantiate(characterPrefabs[characterIndex2], transform);
    }
}