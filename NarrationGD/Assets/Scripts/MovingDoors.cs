using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoors : MonoBehaviour
{
    public AudioSource doorSound;

    public GameObject linkedGO;

    GameObject doorDown;
    GameObject doorUp;

    Vector3 doorDownSavePos;
    Vector3 doorUpSavePos;

    public bool isLocked=false;// variable qui ouvre/ferme les portes

    void Start()
    {

        doorDown = this.gameObject.transform.GetChild(0).gameObject;
        doorDownSavePos = doorDown.transform.position;

        doorUp = this.gameObject.transform.GetChild(1).gameObject;
        doorUpSavePos = doorUp.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.gameObject.transform.position, GameObject.Find("ActualPlayer").transform.position);
        if (dist <= 5f && isLocked==false)
        {
            if ((doorUp.transform.position == doorUpSavePos)||(doorDown.transform.position == doorDownSavePos))
            {
                doorSound.Play();
                doorDown.LeanMoveY(doorDownSavePos.y-2, 0.35f);
                doorUp.LeanMoveY(doorUpSavePos.y+1, 0.35f);
            }
        }
        else
        {
            if ((doorUp.transform.position != doorUpSavePos) || (doorDown.transform.position != doorDownSavePos))
            {
                doorDown.LeanMoveY(doorDownSavePos.y, 0.35f);
                doorUp.LeanMoveY(doorUpSavePos.y, 0.35f);
            }
        }
    }

    public void KeyForDoor()
    {
        isLocked = !isLocked;
    }
}
