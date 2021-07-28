using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryGameInputField : MonoBehaviour
{
    float haricot = 0;
    float carrote = 0;
    float patate = 0;
    int ind = 0;

    [Header("Objets")]
    public GameObject CaissesNormales;
    public GameObject CaissesTrop;
    public GameObject cuistot;

    public void Awake()
    {
        cuistot = GameObject.Find("Cuisinier");
    }
    public void Update()
    {
        if (this.gameObject.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                switch (ind)
                {
                    case 0:
                        setHaricot(1375);
                        ind++;
                        break;

                    case 1:
                        setCarrote(1375);
                        ind++;
                        break;

                    case 2:
                        setPatate(1375);
                        ind++;
                        break;

                    default:
                        break;
                }
                GameObject.Find("DialogueManager").GetComponent<DialogueManager>().DisplayNextSentence();
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                switch (ind)
                {
                    case 0:
                        setHaricot(1350);
                        ind++;
                        break;

                    case 1:
                        setCarrote(1350);
                        ind++;
                        break;

                    case 2:
                        setPatate(1350);
                        ind++;
                        break;

                    default:
                        break;
                }
                GameObject.Find("DialogueManager").GetComponent<DialogueManager>().DisplayNextSentence();
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                switch (ind)
                {
                    case 0:
                        setHaricot(1325);
                        ind++;
                        break;

                    case 1:
                        setCarrote(1325);
                        ind++;
                        break;

                    case 2:
                        setPatate(1325);
                        ind++;
                        break;

                    default:
                        break;
                }
                GameObject.Find("DialogueManager").GetComponent<DialogueManager>().DisplayNextSentence();
            }
        }
    }


    public void setHaricot(int value)
    {
        haricot = value;
    }

    public void setCarrote(int value)
    {
        carrote = value;
    }

    public void setPatate(int value)
    {
        patate = value;
    }

    public void calculerTotal()
    {
        float result = patate + carrote + haricot;

        if (result < 4050)
        {
            GameObject.Find("Captain").transform.localPosition = new Vector3(1.54f, -16.26681f, 3.8f);
            GameObject.Find("Captain").GetComponent<DialogueTrigger>().newDialog_1();
            cuistot.transform.localPosition = new Vector3(-13.46f, -16.26681f,34.8f);
            cuistot.LeanMoveLocalY(-15f, 4).setLoopPingPong();
        }

        if (result == 4050)
        {
            cuistot.GetComponent<DialogueTrigger>().newDialog_2();
            CaissesNormales.SetActive(true);
        }

        if (result > 4050)
        {
            cuistot.transform.localPosition = new Vector3(1.54f, -16.26681f, -4.2f);
            cuistot.GetComponent<DialogueTrigger>().newDialog_3();
            CaissesTrop.SetActive(true);
        }
    }

    public void videStocl()
    {
        CaissesTrop.SetActive(false);
    }
}
