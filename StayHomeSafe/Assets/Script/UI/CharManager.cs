using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] characters;

    public int characterIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCharacter(int index)
    {
        this.characterIndex = index;
        //characters[index].SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene("InGame");
        PlayerPrefs.SetInt("CharacterIndex", characterIndex);
    }
}
