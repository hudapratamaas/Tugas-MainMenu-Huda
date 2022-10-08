using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtama : MonoBehaviour
{
    public void PlayGames()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    List<int> widths = new List<int>() {568, 960, 1280, 1920};
    List<int> heights = new List<int>() {320, 540, 800, 1080};

    public void SetScreenSize (int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }
    public void SetFullScreen (bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }

}
