using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnminationModification : MonoBehaviour
{

    public Transform parentTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(-parentTransform.localScale.x, -parentTransform.localScale.y, parentTransform.localScale.z);
    }


   
}
