using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectionTrigger : MonoBehaviour
{
    GameObject Player;
    public bool securityTrigger;
    GameObject Voice;

  

    private void Awake()
    {
        Player=GameObject.Find("ActualPlayer");
        Voice = GameObject.Find("La voix off");
        
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position,Player.transform.position)<3)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                this.GetComponent<DialogueTrigger>().TriggerDialogue();
            }
         
        } 
      
    
    }

    public void harrassentVoice()
    {
        Invoke("displayAlarm", 15);
    }
    public  void stopItNow()
    {
        CancelInvoke();
    }

    public void displayAlarm()
    {
        Voice.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
    
}
