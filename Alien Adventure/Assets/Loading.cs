using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField]
    private Image _progressBar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }
    IEnumerator LoadAsyncOperation()
    {
        // buat async operasi
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync("Menu");
        while (gameLevel.progress < 1)
        {
            /// membuat fill async operation progress
            _progressBar.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
        /// ketika finish, load the game scene
    }
}
