using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frequence : MonoBehaviour
{
    public float freq;
    float frequencecomp;

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                frequencecomp = 102.2f;
                this.gameObject.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                frequencecomp = 93.2f;
                this.gameObject.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                frequencecomp = 48.9f;
                this.gameObject.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                frequencecomp = 104.2f;
                this.gameObject.SetActive(false);
            }
        }
    }

    bool result()
    {
        if (freq == frequencecomp)
        {
            return true;
        }

        return false;
    }

}
