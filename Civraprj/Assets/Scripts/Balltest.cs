using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balltest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall()
    {
        Instantiate(gameObject, new Vector3 (1.072f,1.1f,0f), transform.rotation);
    }


}
