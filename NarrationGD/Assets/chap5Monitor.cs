using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chap5Monitor : MonoBehaviour
{
    public GameObject monitor;
    public Text quest;
    public GameObject CM;
    public bool security=false;

    
    private void OnTriggerEnter(Collider other)
    {
        if (CM.GetComponent<ChapterManager>().c5 && other.gameObject.name=="ActualPlayer"&& security)
        {
            monitor.GetComponent<DialogueTrigger>().TriggerDialogue();
        }
        
    }

    public void  GoToCap()
    {
        quest.text = "Allez voir le capitaine";
    }
    public void securitrigger()
    {
        security = true;
    }
}
