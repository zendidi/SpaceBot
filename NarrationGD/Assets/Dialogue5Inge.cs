using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue5Inge : MonoBehaviour
{
    public Text quest;
    public GameObject CM;
    public bool security=false;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ActualPlayer" && CM.GetComponent<ChapterManager>().c5&& security)
        {
            quest.text = "Le jardinier à besoin de toi";
            Debug.Log("coucou");
        }
    }

    public void securitrigger()
    {
        security = true;
    }
}
