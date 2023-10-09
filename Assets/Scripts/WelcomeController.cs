using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WelcomeController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textbox;

    [SerializeField]
    TextMeshProUGUI prizebox;

    public void Play() 
    {
        StateManager.Instance.setName(textbox.text);
        LevelManager.Instance.NextScene();
    }

    private void Start()
    {
        AudioManager.Instance.PlayMusic("Theme");
    }
}
