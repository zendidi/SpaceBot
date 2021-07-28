using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowScreen : MonoBehaviour
{
    GameObject theVoice;
    public GameObject DamagedScreen;
    public GameObject fixedScreen;
    public GameObject canvasDamagedScreen;
    GameObject MyPlayer;
    public AudioSource ReparationSound;
    public GameObject GM;
    bool isBroken;
    public Text quest;


    private void Start()
    {
        theVoice = GameObject.Find("La voix off");
        MyPlayer = GameObject.FindGameObjectWithTag("Player");
        isBroken = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="ActualPlayer"&& isBroken)
        {
            isBroken = !isBroken;
            ReparationSound.Play();
            fixedScreen.SetActive(true);
            canvasDamagedScreen.SetActive(true);
            GM.GetComponent<GameManager>().MonitorRepair();
            DamagedScreen.SetActive(false);
            GameObject.Find("Ingenieur").GetComponent<DialogueTrigger>().newDialog_3();
        }      
    }

    public void unlockMonitor()
    {
        isBroken = true;
    }

}
