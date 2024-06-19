using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gawlierubg : MonoBehaviour
{
    public GameObject PlayerPart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerPart.transform.position;
        transform.rotation = PlayerPart.transform.rotation;
    }
}
