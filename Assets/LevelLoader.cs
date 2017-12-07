using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    #region Public Members

    public Slider m_slider;
    public Text m_text;

    #endregion

    #region Public void

    public void LevelLoađing(int _levelToLoad)
    {
        StartCoroutine(LoadLevelAsync(_levelToLoad));
    }

    IEnumerator LoadLevelAsync(int _levelToLoad)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(_levelToLoad);

        while ( !operation.isDone )
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            Debug.Log("Chargement: " + operation.progress);

            m_slider.value = progress;
            m_text.text = (progress * 100) + " %";

            yield return null;

            // Same as:
            // yield return new WaitForSeconds(0f);
        }

        
    }

    #endregion

    #region System

    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
