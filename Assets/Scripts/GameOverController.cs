using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI nameText;

    [SerializeField]
    TextMeshProUGUI prizeText;


    void Awake()
    {
        nameText.text = StateManager.Instance.getName();
        prizeText.text = StateManager.Instance.getPrize();

    }

    public void PlayAgain()
    {
        StateManager.Instance.setName(nameText.text);
        StateManager.Instance.setPrize(prizeText.text);
        LevelManager.Instance.FirstScene();
    }
}
