using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    private int currentAlphabet;

    public string url; // This is where you'll input your URL in the Unity Editor

    private void Awake() {

        SelectAlphabet(0);
    
    }
    
    private void SelectAlphabet(int _index) {

        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount-1);

        for (int i = 0; i < transform.childCount; i++) {
        
            transform.GetChild(i).gameObject.SetActive(i == _index);

        }

    }

    public void ChangeAlphabet(int _change) {

        currentAlphabet += _change;
        SelectAlphabet(currentAlphabet);

    }

    public void Exit()
    {

        SceneManager.LoadScene("MenuScreen");

    }

    public void OpenLink()
    {
        Application.OpenURL(url);
    }

}
