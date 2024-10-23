using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public GameObject fyp1SelectionScreen;
    public GameObject fyp2SelectionScreen;
    public GameObject mainSelectionScreen;

    public GameObject level2Button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        string checklevel2lock = PlayerPrefs.GetString("checklevel2");

        if (checklevel2lock == "unlocked")
        {

            level2Button.SetActive(true);

        }

    }

    public void fyp1() {

        fyp1SelectionScreen.SetActive(true);

    }

    public void fyp2()
    {

        fyp2SelectionScreen.SetActive(true);

    }

    public void back()
    {

        mainSelectionScreen.SetActive(true);
        fyp2SelectionScreen.SetActive(false);
        fyp1SelectionScreen.SetActive(false);

    }

    public void fyp1AutoScene()
    {

        SceneManager.LoadScene("FYP1 Auto");

    }

    public void fyp2AutoScene()
    {

        SceneManager.LoadScene("FYP2 Auto");

    }

    public void fyp1LockScene()
    {

        SceneManager.LoadScene("FYP1 Lock");

    }

    public void fyp2LockScene()
    {

        SceneManager.LoadScene("FYP2 Lock");

    }

    public void Exit()
    {

        Application.Quit();

    }

}
