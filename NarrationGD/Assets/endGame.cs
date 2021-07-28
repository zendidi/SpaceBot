using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public void scroll()
    {
        LeanTween.moveLocalY(gameObject, 0, 2.5f);
    }
}
