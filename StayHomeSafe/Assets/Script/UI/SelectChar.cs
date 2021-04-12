using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChar : MonoBehaviour
{
    private int selectedCharacterIndex;
    private int selectedCharacterIndex2;
    private int selectedCharacterIndex3;
    private int selectedCharacterIndex4;
    private Color desiredColor;
    private GameObject characterselect;
    private GameObject timer;
    public GameObject P3;
    public GameObject P4;

    [Header("List of character")]
    [SerializeField] private List<CharacterSelectObject> characterList = new List<CharacterSelectObject>();

    [Header("UI References")]
    [SerializeField] private Text characterName;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColor;
    [SerializeField] private Text characterName2;
    [SerializeField] private Image characterSplash2;
    [SerializeField] private Image backgroundColor2;
    [SerializeField] private Text characterName3;
    [SerializeField] private Image characterSplash3;
    [SerializeField] private Image backgroundColor3;
    [SerializeField] private Text characterName4;
    [SerializeField] private Image characterSplash4;
    [SerializeField] private Image backgroundColor4;

    [Header("Sounds")]
    [SerializeField] private AudioClip arrowClickSFX;
    [SerializeField] private AudioClip characterSelectMusic;

    [Header("Tweaks")]
    [SerializeField] private float backgroundColorTransitionSpeed = 10.0f;

    private void Start()
    {
        UpdateCharacterSelectionUI();
        selectedCharacterIndex = 0;
        PlayerPrefs.SetInt("CharacterIndex", selectedCharacterIndex);
        selectedCharacterIndex2 = 0;
        PlayerPrefs.SetInt("CharacterIndex2", selectedCharacterIndex2);
        selectedCharacterIndex3 = 0;
        PlayerPrefs.SetInt("CharacterIndex3", selectedCharacterIndex3);
        selectedCharacterIndex4 = 0;
        PlayerPrefs.SetInt("CharacterIndex4", selectedCharacterIndex4);
        PlayerPrefs.SetInt("P3", 0);
        PlayerPrefs.SetInt("P4", 0);
    }

    private void Update()
    {
        backgroundColor.color = Color.Lerp(backgroundColor.color, desiredColor, Time.deltaTime * backgroundColorTransitionSpeed);
        if (Input.GetKeyUp(KeyCode.F3))
        {
            P3.SetActive(true);
            PlayerPrefs.SetInt("P3",1);
        }
        if (Input.GetKeyUp(KeyCode.F4))
        {
            P4.SetActive(true);
            PlayerPrefs.SetInt("P4", 1);
        }
    }
    public void LeftArrow()
    {
            selectedCharacterIndex--;
            if (selectedCharacterIndex < 0)
                selectedCharacterIndex = 3;
            UpdateCharacterSelectionUI();
        this.selectedCharacterIndex = selectedCharacterIndex;
        PlayerPrefs.SetInt("CharacterIndex", selectedCharacterIndex);
    }
    public void LeftArrow2()
    {
        selectedCharacterIndex2--;
        if (selectedCharacterIndex2 < 0)
            selectedCharacterIndex2 = 3;
        UpdateCharacterSelectionUI();
        this.selectedCharacterIndex2 = selectedCharacterIndex2;
        PlayerPrefs.SetInt("CharacterIndex2", selectedCharacterIndex2);
    }
    public void LeftArrow3()
    {
        selectedCharacterIndex3--;
        if (selectedCharacterIndex3 < 0)
            selectedCharacterIndex3 = 3;
        UpdateCharacterSelectionUI();
        this.selectedCharacterIndex3 = selectedCharacterIndex3;
        PlayerPrefs.SetInt("CharacterIndex3", selectedCharacterIndex3);
    }
    public void LeftArrow4()
    {
        selectedCharacterIndex4--;
        if (selectedCharacterIndex4 < 0)
            selectedCharacterIndex4 = 3;
        UpdateCharacterSelectionUI();
        this.selectedCharacterIndex4 = selectedCharacterIndex4;
        PlayerPrefs.SetInt("CharacterIndex4", selectedCharacterIndex4);
    }
    public void RightArrow()
    {
            selectedCharacterIndex++;
            if (selectedCharacterIndex > 3)
            selectedCharacterIndex = 0;
            UpdateCharacterSelectionUI();
        this.selectedCharacterIndex = selectedCharacterIndex;
        PlayerPrefs.SetInt("CharacterIndex", selectedCharacterIndex);
    }
    public void RightArrow2()
    {
        selectedCharacterIndex2++;
        if (selectedCharacterIndex2 > 3)
            selectedCharacterIndex2 = 0;
        UpdateCharacterSelectionUI();
        this.selectedCharacterIndex2 = selectedCharacterIndex2;
        PlayerPrefs.SetInt("CharacterIndex2", selectedCharacterIndex2);
    }
    public void RightArrow3()
    {
        selectedCharacterIndex3++;
        if (selectedCharacterIndex3 > 3)
            selectedCharacterIndex3 = 0;
        UpdateCharacterSelectionUI();
        this.selectedCharacterIndex3 = selectedCharacterIndex3;
        PlayerPrefs.SetInt("CharacterIndex3", selectedCharacterIndex3);
    }
    public void RightArrow4()
    {
        selectedCharacterIndex4++;
        if (selectedCharacterIndex4 > 3)
            selectedCharacterIndex4 = 0;
        UpdateCharacterSelectionUI();
        this.selectedCharacterIndex4 = selectedCharacterIndex4;
        PlayerPrefs.SetInt("CharacterIndex4", selectedCharacterIndex4);
    }

    public void Confirm()
    {
    }
    private void UpdateCharacterSelectionUI()
    {
        characterSplash.sprite = characterList[selectedCharacterIndex].splash;
        characterName.text = characterList[selectedCharacterIndex].characterName;
        desiredColor = characterList[selectedCharacterIndex].characterColor;
        characterSplash2.sprite = characterList[selectedCharacterIndex2].splash;
        characterName2.text = characterList[selectedCharacterIndex2].characterName;
        desiredColor = characterList[selectedCharacterIndex2].characterColor;
        characterSplash3.sprite = characterList[selectedCharacterIndex3].splash;
        characterName3.text = characterList[selectedCharacterIndex3].characterName;
        desiredColor = characterList[selectedCharacterIndex3].characterColor;
        characterSplash4.sprite = characterList[selectedCharacterIndex4].splash;
        characterName4.text = characterList[selectedCharacterIndex4].characterName;
        desiredColor = characterList[selectedCharacterIndex4].characterColor;
    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public Color characterColor;
    }
}
