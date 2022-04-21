using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Canvas settings;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void OnClickResume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    public void OnClickSettings()
    {
        settings.enabled = true;
        GetComponent<Canvas>().enabled = false;
    }

    public void OnClickExit()
    {
        //Application.Quit();

        EditorApplication.ExitPlaymode();
    }
}
