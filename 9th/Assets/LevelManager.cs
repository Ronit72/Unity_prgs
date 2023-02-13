using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public GameObject loadingPanel;
    public Slider loadingBar;
    public Text loadingText;
    public void LoadLevel(string levelName)
    {
        StartCoroutine(LoadSceneAsync(levelName));//waits till yeild return null
    }
    IEnumerator LoadSceneAsync(string levelName)
    {
        loadingPanel.SetActive(true);
        loadingText.text = "0%";
        yield return StartCoroutine(Wait2Seconds());
        loadingBar.value = 0.5f;
        loadingText.text = "50%";
        yield return StartCoroutine(Wait2Seconds());
        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);
        while (!op.isDone)
        {

            float progress = Mathf.Clamp01(op.progress / .9f);
            loadingBar.value = progress;
            if (progress * 100f > 51f)
            {
                loadingText.text = progress * 100f + "%";
            }
            yield return null;
        }
    }
    IEnumerator Wait2Seconds()
    {
        yield return new WaitForSeconds(2f);
    }
}