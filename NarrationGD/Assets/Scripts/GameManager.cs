using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    static int monitorCheck;
    public Text quest;
    // Start is called before the first frame update
    void Start()
    {
        monitorCheck = 0;
    }

    public static void lightsOn()
    {
        GameObject[] lumieres;
        lumieres = GameObject.FindGameObjectsWithTag("Lights");

        foreach (GameObject lumiere in lumieres)
        {
            lumiere.GetComponent<Light>().enabled = true;
        }
    }

    public static void lightsOff()
    {
        GameObject[] lumieres;
        lumieres = GameObject.FindGameObjectsWithTag("Lights");

        foreach (GameObject lumiere in lumieres)
        {
            lumiere.GetComponent<Light>().enabled = false;
        }
    }

    public void MonitorRepair()
    {
        monitorCheck++;
        if (monitorCheck==4)
        {
            quest.text = "Retourner voir Géraldine l'ingénieur";
        }
    }

}
