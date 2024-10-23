using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerAuto : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    private int currentAlphabet;

    public string url; // This is where you'll input your URL in the Unity Editor

    private void Awake()
    {

        SelectAlphabet(0);

    }

    private void SelectAlphabet(int _index)
    {

        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {

            transform.GetChild(i).gameObject.SetActive(i == _index);

        }

    }

    public void ChangeAlphabet(int _change)
    {

        currentAlphabet += _change;
        SelectAlphabet(currentAlphabet);

    }

    public void Exit()
    {

        SceneManager.LoadScene("MenuScreen");

    }

    void Start()
    {
        StartCoroutine(CallFunctionEvery5Seconds());
    }

    IEnumerator CallFunctionEvery5Seconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f); // Wait for 5 seconds
            // Call your function here
            YourFunction();

            
        }
    }

    void YourFunction()
    {
        // Your function code here
        ChangeAlphabet(1);
    }

    public void OpenLink()
    {
        Application.OpenURL(url);
    }

}
