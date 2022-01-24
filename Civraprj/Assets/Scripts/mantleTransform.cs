using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mantleTransform : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Earth"))
        {
            other.transform.localScale = new Vector3(.125f, .125f, .125f);

            Destroy(this);
        }
    }
}


