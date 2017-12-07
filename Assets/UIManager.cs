using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Public Members

    public Animator m_animator;

    public GameObject m_PlaySubMenu;

    public GameObject m_panelAreYouSure;

    public AudioSource m_hoverSound;

    #endregion

    #region Public void

    public void ToggleCampaign(bool _status)
    {
        m_PlaySubMenu.SetActive(_status);

        if (_status)
        {
            ToggleAreYouSure(false);
            ToggleSettings(false);
        }
    }

    public void ToggleAreYouSure(bool _status)
    {
        m_panelAreYouSure.SetActive(_status);

        if (_status)
        {
            ToggleCampaign(false);
            ToggleSettings(false);

        }
    }

    public void ToggleSettings(bool _status)
    {
        m_animator.SetBool("Settings", _status);

        if (_status)
        {
            ToggleCampaign(false);
            ToggleAreYouSure(false);

        }
    }

    public void AreYouSureAnswer(bool _quit)
    {
        if (_quit)
        {
            Application.Quit();
            Debug.Log("QUITTING");
            Debug.Break();
        }
        else
            ToggleAreYouSure(false);
    }

    public void PlayOver()
    {
        m_hoverSound.Stop();
        m_hoverSound.Play();
    }

    #endregion

    #region System

    private void Awake ()
    {
        if (m_animator == null)
            m_animator = GetComponent<Animator>();
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
