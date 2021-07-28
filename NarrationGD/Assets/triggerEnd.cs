using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class triggerEnd : MonoBehaviour
{
    public GameObject CM;
    public GameObject textes;
    public bool gameEnd=false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="ActualPlayer" && CM.GetComponent<ChapterManager>().c5 && gameEnd)
        {
            textes.GetComponent<endGame>().scroll();
        }
    }

    public void gedaan()
    {
        Debug.Log("que pasa?");
        gameEnd = true;
    }
}
