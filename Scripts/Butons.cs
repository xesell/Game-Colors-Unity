using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butons : MonoBehaviour
{
    public GameObject m_off, m_on;
    public Sprite layer_blue, layer_red;
    private void Start()
    {
        if (gameObject.name == "Music") { 
        if (PlayerPrefs.GetString("Music") == "no")
        {
            m_off.SetActive(true);
            m_on.SetActive(false);
        }
        else if (PlayerPrefs.GetString("Music") != "no")
        {
            m_off.SetActive(false);
            m_on.SetActive(true);
        }
    }

        }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_red;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }

    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("play");
                break;
            case "Reting":
                Application.OpenURL("");
                break;
            case "ADS":
                break;
            case "How to":
                Application.LoadLevel("How to");
                break;
            case "Restore":
                break;
            case "Music":
                if (PlayerPrefs.GetString("Music") != "no")
                { PlayerPrefs.SetString("Music", "no");
                m_off.SetActive(true);
                m_on.SetActive(false); }
                else{
                    PlayerPrefs.SetString("Music", "yes");
                    m_off.SetActive(false);
                    m_on.SetActive(true);
                    }
                break;
            case "Replay":
                Application.LoadLevel("play");
                break;
            case "Home":
                Application.LoadLevel("main");
                break;
            case "FaceBook":
                Application.OpenURL("http://facebook.com");
                break;
            case "Close":
                Application.LoadLevel("main");
                break;
        }
    }
}
