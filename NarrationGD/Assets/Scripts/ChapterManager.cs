using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterManager : MonoBehaviour
{


    [Header("Personnages")]
    public GameObject kyle;
    public GameObject Capitaine;
    public GameObject Cuisinier;
    public GameObject Second;
    public GameObject Jardinier;
    public GameObject Developpeur;
    public GameObject Quaternius;
    public GameObject MonitorVoice;
    public Text quest;


    [Header("Chapitre 1")]
    public GameObject chp1;
    
    [Header("Chapitre 2")]
    public GameObject chp2;
    public GameObject porteFermee;
    public GameObject TorchLight;

    [Header("Chapitre 3")]
    public GameObject chp3;

    [Header("Chapitre 4")]
    public GameObject chp4;
    public GameObject screen1;
    public GameObject screen2;
    public GameObject screen3;
    public GameObject screen4;
    public GameObject on;
    public GameObject off;
    public GameObject qte;

    [Header("Chapitre 5")]
    public GameObject chp5;
    public bool c5;
    GameObject[] screens;
    private void Awake()
    {
        screens = GameObject.FindGameObjectsWithTag("KaputScreen");
        foreach (var item in screens)
        {
            item.SetActive(false);
        }
        c5 = false;
    }

    private void OnEnable()
    {
        if (chp1.activeSelf == true)
        {
            quest.text = "Parler au Capitaine";
            kyle.transform.position = new Vector3(-4.31f, 2.23f, -15.86f);

            Second.GetComponent<DialogueTrigger>().newDialog_5();
            Jardinier.GetComponent<DialogueTrigger>().newDialog_5();
            Cuisinier.GetComponent<DialogueTrigger>().newDialog_5();
            Developpeur.GetComponent<DialogueTrigger>().newDialog_5();

            Capitaine.transform.localPosition = new Vector3(15.7f, -16.26681f, 9.3f);
            Second.transform.localPosition = new Vector3(16.29f, -16.26681f, -31.54f);
            Jardinier.transform.localPosition = new Vector3(14.6f, -16.26681f, -32.22f);
            Developpeur.transform.localPosition = new Vector3(15.22f, -16.26681f, -34.72f);
            Cuisinier.transform.localPosition = new Vector3(17.54f, -16.26681f, -34.2f);

            chp1.SetActive(false);
            this.gameObject.SetActive(false);
        }

        if (chp2.activeSelf == true)
        {
            quest.text = "Trouver le second afin de savoir ce qu'il se passe";
            Second.GetComponent<DialogueTrigger>().newDialog_1();

            Jardinier.GetComponent<DialogueTrigger>().newDialog_0();
            Cuisinier.GetComponent<DialogueTrigger>().newDialog_5();

           
            Capitaine.GetComponent<DialogueTrigger>().newDialog_5();
            TorchLight.SetActive(true);
            GameManager.lightsOff();

            kyle.transform.position = new Vector3(-4.31f, 2.23f, -15.86f);

            Capitaine.transform.localPosition = new Vector3(46.3f, -14.27f, -12.7f);
            Second.transform.localPosition = new Vector3(-20.7f, -16.26681f, -13.5f);
            Jardinier.transform.localPosition = new Vector3(-30.4f, -16.26681f, -28.44f);
            Developpeur.transform.localPosition = new Vector3(30.22f, -16.26681f, -27.72f);
            Cuisinier.transform.localPosition = new Vector3(8.54f, -16.26681f, -6.2f);
            Quaternius.transform.localPosition = new Vector3(-43.6f, -17.60888f, -32.27f);

            porteFermee.GetComponent<MovingDoors>().KeyForDoor();

            chp2.SetActive(false);
            this.gameObject.SetActive(false);
        }

        if (chp3.activeSelf == true)
        {
            quest.text = "Trouver le cuisinier";

            Cuisinier.GetComponent<DialogueTrigger>().newDialog_0();
            Jardinier.GetComponent<DialogueTrigger>().newDialog_5();
            Capitaine.GetComponent<DialogueTrigger>().newDialog_5();
            Second.GetComponent<DialogueTrigger>().newDialog_5(); 
            Developpeur.GetComponent<DialogueTrigger>().newDialog_5(); 

            kyle.transform.position = new Vector3(-4.31f, 2.23f, -15.86f);
            Capitaine.transform.localPosition = new Vector3(46.3f, -14.27f, -12.7f);
            Jardinier.transform.localPosition = new Vector3(-30.4f, -16.26681f, -28.44f);

            Second.transform.localPosition = new Vector3(19f, -16.26681f, -36.5f);
            Developpeur.transform.localPosition = new Vector3(20.22f, -16.26681f, -37.12f);
            Cuisinier.transform.localPosition = new Vector3(1.54f, -16.26681f, 3.8f);

            chp3.SetActive(false);
            this.gameObject.SetActive(false);
        }

        if (chp4.activeSelf == true)
        {
            
            quest.text = "Rejoins Géraldine l'ingénieur";
            if (qte.GetComponent<MemoryGameInputField>().CaissesTrop)
            {
                qte.GetComponent<MemoryGameInputField>().videStocl();
            }
            
            foreach (var item in screens)
            {
                item.SetActive(true);
            }

            screen1.SetActive(false);
            screen2.SetActive(false);
            screen3.SetActive(false);
            screen4.SetActive(false);

            off.SetActive(true);
            Developpeur.GetComponent<DialogueTrigger>().newDialog_1();

            Capitaine.GetComponent<DialogueTrigger>().newDialog_5();
            Second.GetComponent<DialogueTrigger>().newDialog_5();
            Cuisinier.GetComponent<DialogueTrigger>().newDialog_5();
            Jardinier.GetComponent<DialogueTrigger>().newDialog_5();
            
            kyle.transform.position = new Vector3(-4.31f, 2.23f, -15.86f);

            Capitaine.transform.localPosition = new Vector3(46.3f, -14.27f, -12.7f);
            Second.transform.localPosition = new Vector3(-39f, -16.26681f, 2.5f);
            Developpeur.transform.localPosition = new Vector3(2.25f, -16.26681f, -33f);

            chp4.SetActive(false);
            this.gameObject.SetActive(false);
        }

        if (chp5.activeSelf == true)
        {
            quest.text = "Rejoins le capitaine";
            kyle.transform.position = new Vector3(-4.31f, 2.23f, -15.86f);
            Capitaine.GetComponent<DialogueTrigger>().newDialog_2();
            Second.GetComponent<DialogueTrigger>().newDialog_5();
            Developpeur.GetComponent<DialogueTrigger>().newDialog_5();
            Cuisinier.GetComponent<DialogueTrigger>().newDialog_5();
            Jardinier.GetComponent<DialogueTrigger>().newDialog_5();
            MonitorVoice.GetComponent<DialogueTrigger>().newDialog_1();
            c5 = true;
            //préparer les objets prèt et déjà rangés
            // Panneau bureau, Lit réparé, table mise, moteur réparé, engrais pris des stocks
            chp5.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (chp1 || chp2 || chp3 || chp4 || chp5)
        {
            if (Input.anyKey)
            {
                chp1.SetActive(false);
                chp2.SetActive(false);
                chp3.SetActive(false);
                chp4.SetActive(false);
                chp5.SetActive(false);
            }
        }
    }

    public void QuaterniusEnPrison()
    {
        Quaternius.transform.localPosition = new Vector3(-37.863f, -16.545f, -25.102f);
    }

    public void ProjetcorOn()
    {
        off.SetActive(false);
        on.SetActive(true);
    }

    public void Text2Chap2_second()
    {
        quest.text = "Trouver le générateur et le réparer";
    }

    public void Text2Chap3_cuistot()
    {
        quest.text = "Aller commander les bons ingrédients au jardinier";
    }

    public void questFoodDone()
    {
        quest.text = "retourner voir le cuistot";
    }
    public void Text2Chap4_Ingenieur()
    {
        quest.text = "Réparer les ordinateurs de navigation de la salle de controle";
    }

    public void DelationQuaternienne()
    {
        quest.text = "Aller dénoncer quaternius à l'ingénieur ou parler au second";

    }
    public void Chap5Inge()
    {
        quest.text = "Réparer de nouveau les moniteurs du bureau";
    }
    public void Chap5Jardi()
    {
        quest.text = "Aller chercher de l'engrais en réserve";
    }
    public void Chap5cap1()
    {
        quest.text = "Aller de nouveau réparer les générateurs ";
    }
    public void lastone()
    {
        quest.text = "Rejoignez votre box ou sortez";
    }
}
