using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField]
    private Canvas menu;

    [SerializeField]
    private Toggle soundToggle;

    [SerializeField]
    private Slider volumeSlider;

    [SerializeField]
    private Dropdown complexityValue;

    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("SavedCheckBoxSound"))
        {
            soundToggle.isOn = PlayerPrefs.GetInt("SavedCheckBoxSound") == 1 ? true : false;
            volumeSlider.value = PlayerPrefs.GetFloat("SavedVolume");
            complexityValue.value = PlayerPrefs.GetInt("SavedComplexity");
            Debug.Log("Game data loaded!");
        }
    }

    public void OnClickBack()
    {
        PlayerPrefs.SetInt("SavedCheckBoxSound", soundToggle.isOn ? 1 : 0);
        PlayerPrefs.SetFloat("SavedVolume", volumeSlider.value);
        PlayerPrefs.SetInt("SavedComplexity", complexityValue.value);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");

        menu.enabled = true;
        GetComponent<Canvas>().enabled = false;
    }
}
