using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBooth : MonoBehaviour
{
    public float displayTime = 6.0f;
    public GameObject dialogBox;
    public Conversation conversation;
    public GameObject arrow;

    private float timerDisplay;
    private int linenumber;
    private int x = 0;
    private bool counter = true;

    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -4.0f;
        linenumber = conversation.lines.Length;
    }

    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
                x = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && gameObject.activeSelf && x < linenumber-1)
        {
            x++;
            GetComponentInChildren<TMPro.TextMeshProUGUI>().text = conversation.lines[x].text;
        }
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
        GetComponentInChildren<TMPro.TextMeshProUGUI>().text = conversation.lines[x].text;
    }
    public void ShowArrow()
    {
        if (counter)
        {
            arrow.SetActive(true);
        }
        
    }
    public void HideArrow()
    {
        arrow.SetActive(false);
        counter = false;
    }
}
