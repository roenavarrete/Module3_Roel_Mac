using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("alien"))
        {

            transform.position = new Vector3(19.8f, 0f, -1.99f);

   

        }

    }




}
