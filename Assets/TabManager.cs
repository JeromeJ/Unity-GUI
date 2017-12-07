using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    #region Public Members

    public Button m_selected;
    public AnimationCurve m_animationCurve;

    #endregion

    #region Public void

    public void ChangeSelect(Button _newSelection)
    {
        m_selected.transform.Find("Submenu").gameObject.SetActive(false);
        m_selected = _newSelection;
        m_selected.transform.Find("Submenu").gameObject.SetActive(true);
    }

    #endregion

    #region System

    private void Awake()
    {
        m_selected.transform.Find("Submenu").gameObject.SetActive(true);
        m_selected.Select();
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
