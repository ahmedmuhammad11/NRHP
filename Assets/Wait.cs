using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Globalization;

public class Wait : MonoBehaviour
{

    public string sceneToLoad;
    public float waitsec;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(waitsec);

        SceneManager.LoadScene(sceneToLoad);

    }
}