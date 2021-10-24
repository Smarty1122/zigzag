using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerchecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "ball")
        {
            Falldown();

        }

    }

    void Falldown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.parent.gameObject, 1.3f);
    }
}
