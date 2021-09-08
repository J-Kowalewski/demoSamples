using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    public Conversation conversation;

    private int linenumber;
    private int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        linenumber = conversation.lines.Length;
        GetComponent<TMPro.TextMeshProUGUI>().text = conversation.lines[x].text;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameObject.activeSelf && x < linenumber)
        {
            x++;
            GetComponent<TMPro.TextMeshProUGUI>().text = conversation.lines[x].text;
        }
        
    }
}
