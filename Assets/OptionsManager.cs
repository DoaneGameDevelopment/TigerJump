using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsManager : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Set slider to current volume
        volumeSlider.value = AudioListener.volume;

        // Connect slider to volume control
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
