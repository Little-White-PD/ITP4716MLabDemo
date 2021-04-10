using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChar : MonoBehaviour
{
    private int selectedCharacterIndex;
    private Color desiredColor;
    private GameObject characterselect;
    private GameObject timer;

    [Header("List of character")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();

    [Header("UI References")]
    [SerializeField] private Text characterName;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColor;

    [Header("Sounds")]
    [SerializeField] private AudioClip arrowClickSFX;
    [SerializeField] private AudioClip characterSelectMusic;

    [Header("Tweaks")]
    [SerializeField] private float backgroundColorTransitionSpeed = 10.0f;

    private void Start()
    {
        UpdateCharacterSelectionUI();
    }

    private void Update()
    {
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);
    }
    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
            selectedCharacterIndex = characterList.Count - 1;

        UpdateCharacterSelectionUI();
    }

    public void RightArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
            selectedCharacterIndex = 0;

        UpdateCharacterSelectionUI();
    }

    public void Confirm()
    {
    }
    private void UpdateCharacterSelectionUI()
    {
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
        characterName.text = characterList[selectedCharacterIndex].characterName;
        desiredColor = characterList[selectedCharacterIndex].characterColor;
    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public Color characterColor;
    }
}
