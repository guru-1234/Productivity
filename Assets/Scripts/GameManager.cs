using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas ShowCanvas;
    public static bool Replayed=false;
    private void Awake() {
        ShowCanvas.gameObject.SetActive(false);
    }
    public void ProductivityTab()
    {
        ShowCanvas.gameObject.SetActive(true);
        Time.timeScale=0;
    }
    public void ReturnWork()
    {
        ShowCanvas.gameObject.SetActive(false);
        Time.timeScale=1;
    }
    public void GamePause(bool Pause)
    {
        if(Pause)
        {
            Time.timeScale=0;
        }
        if(!Pause)
        {
            Time.timeScale=1;
        }
    }
    public void Replay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Replayed=true;

    }
    public void GameQuit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying=false;
        #else
            Application.Quit();
        #endif
    }
}
