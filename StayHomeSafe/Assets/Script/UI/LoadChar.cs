using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadChar : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characterPrefabs;
    void Start()
    {
        LoadCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadCharacter()
    {
        int characterIndex = PlayerPrefs.GetInt("CharacterIndex");
        Instantiate(characterPrefabs[characterIndex]);
    }
}
