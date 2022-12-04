using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainAR");
    }

    public void LoadEnterScene()
    {
        SceneManager.LoadScene("EnterScene");
    }

    public void LoadContactUsScene()
    {
        SceneManager.LoadScene("ContactUsScene");
    }

    public void LoadChairScene()
    {
        SceneManager.LoadScene("ChairScene");
    }

    public void LoadSofaScene()
    {
        SceneManager.LoadScene("SofaScene");
    }

    public void LoadPoofScene()
    {
        SceneManager.LoadScene("PoofScene");
    }

    public void LoadShelfScene()
    {
        SceneManager.LoadScene("ShelfScene");
    }

    public void LoadTableScene()
    {
        SceneManager.LoadScene("TableScene");
    }

    public void LoadAboutUsScene()
    {
        SceneManager.LoadScene("AboutUsScene");
    }


}
