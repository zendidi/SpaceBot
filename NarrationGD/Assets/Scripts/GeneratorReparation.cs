using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorReparation : MonoBehaviour
{

    bool isReparable = false;
    public GameObject particules;
    public int influence = 0;
    public GameObject Torch;
    public GameObject Porte;
    public AudioSource ReparationSound;
    public Text quest;
    public GameObject second;

    public GameObject CM;

    
    // Update is called once per frame
    void Update()
    {
        if (isReparable)
        {
            if (particules.activeSelf == false)
            {
                particules.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.F) && Vector3.Distance(this.gameObject.transform.position,GameObject.FindGameObjectWithTag("Player").transform.position)<3)
            {
                Debug.Log("J'ai pas été du tout   "+ Vector3.Distance(this.gameObject.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position));
                isReparable = false;
                particules.SetActive(false);
                if (influence!=0)
                {
                    switch (influence)
                    {
                        case 1:
                            ReparationSound.Play();
                            GameManager.lightsOn();
                            GameObject.Find("Quaternius").GetComponent<DialogueTrigger>().newDialog_1();
                            GameObject.Find("Second").GetComponent<DialogueTrigger>().newDialog_2();
                            GameObject.Find("Second").transform.localPosition = new Vector3(-21f, -16.26681f, -15.5f);
                            Porte.GetComponent<MovingDoors>().KeyForDoor();
                            Torch.SetActive(false);
                            quest.text = "Parler A Quaternius";
                            break;

                        case 2:
                            ReparationSound.Play();
                            GameObject[] spritchs;
                            spritchs = GameObject.FindGameObjectsWithTag("Spritcher");
                            GameObject.Find("Herboriste").GetComponent<DialogueTrigger>().newDialog_1();
                            foreach (GameObject spritch in spritchs)
                            {
                                spritch.transform.GetChild(0).gameObject.SetActive(true);
                            }
                            break;
                    }
                }
            }

        }
    }

    public void ccasse()
    {
        isReparable = !isReparable;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CM.GetComponent<ChapterManager>().c5 && other.gameObject.name == "ActualPlayer")
        {
            quest.text = "Aller voir le second";
            second.GetComponent<DialogueTrigger>().newDialog_3();
        }
    }
}
