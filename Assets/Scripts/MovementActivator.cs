using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToActivate2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject>().enabled = true;
        objectToActivate2.GetComponent<MoveObject>().enabled = true;
    }
}
