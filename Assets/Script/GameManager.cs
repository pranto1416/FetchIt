using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> quest;
    public static GameManager instance;
    public GameObject WinningPanel;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void WinCondition()
    {
        WinningPanel.SetActive(true);
        Debug.Log("Done");
    }
}
