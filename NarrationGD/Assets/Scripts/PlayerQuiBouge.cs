using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuiBouge : MonoBehaviour
{
    public CharacterController Controller;
    public float speed;
    public float gravity;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance=0.4f;

    public LayerMask groundMask;

    [Header("Animation + son")]
    public Animator anim;
    public AudioSource myAudio;

    bool isGrounded;
    public Animator anim2;
    GameObject[] pnjs;
    public GameObject TPanel;

    private void Start()
    {
        pnjs = GameObject.FindGameObjectsWithTag("PNJ");
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y<0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right*x+ transform.forward*z;

        if (z != 0)
        {
            if (!myAudio.isPlaying)
            {
                myAudio.Play();
            }
        }

        anim.SetFloat("Vertical", z);

        Controller.Move(move *speed*Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        Controller.Move(velocity * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
        GameObject test = GettingTarget();
        if (test != null)
        {
            anim2.SetBool("isPresent", true);
            Debug.Log(anim2.GetBool("isPresent"));
        }else
        {
            anim2.SetBool("isPresent", false);
            Debug.Log(anim2.GetBool("isPresent"));
        }
    }

     public GameObject GettingTarget()
    {
        for (int i = 0; i < pnjs.Length; i++)
        {
            
            if (Vector3.Distance(transform.position,pnjs[i].transform.position)<3)
            {
                return pnjs[i];
            }
        }
        return null ;
    }


}

