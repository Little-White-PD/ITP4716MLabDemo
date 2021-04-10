using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characters;

    private int characterIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCharacter(int index)
    {
        for(int i = 0;i < characters.Length;i++)
        {
            characters[i].SetActive(false);
        }
        this.characterIndex = index;
        characters[index].SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene("InGame");
        PlayerPrefs.SetInt("CharacterIndex", characterIndex);
    }
}
