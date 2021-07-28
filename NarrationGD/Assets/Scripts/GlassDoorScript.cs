using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorScript : MonoBehaviour
{

    public float howMuchToRotateBro;
    public void RotateDoor()
    {
        gameObject.transform.Rotate(new Vector3(0, howMuchToRotateBro, 0));
    }
}
