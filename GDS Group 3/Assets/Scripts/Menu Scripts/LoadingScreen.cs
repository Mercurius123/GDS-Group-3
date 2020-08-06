using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField]
    private Image LoadingBar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation GameLevel = SceneManager.LoadSceneAsync("MAIN");

        while (GameLevel.progress < 1)
        {
            LoadingBar.fillAmount = GameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
