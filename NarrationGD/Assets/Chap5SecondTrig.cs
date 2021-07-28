using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chap5SecondTrig : MonoBehaviour
{
    public Text quest;
   public GameObject CM;
    public bool DialogCheck= false;
    public GameObject inge;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="ActualPlayer" && CM.GetComponent<ChapterManager>().c5 && DialogCheck)
        {
            quest.text = "Vas parler à l'ingénieur";
            inge.GetComponent<DialogueTrigger>().newDialog_2();
        }
    }

    public void securityTirgger()
    {
        DialogCheck = true;
    }
}
