using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Animator LeftLegCenterOfGravity;
    public int RotationSpeed = 100;
    private Transform ItemTransform;
    /*public GameObject LeftLegCentOfGrav;*/
    // Start is called before the first frame update
    void Start()
    {
        ItemTransform = this.GetComponent<Transform>();
        LeftLegCenterOfGravity = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ItemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
        if (ItemTransform.transform.eulerAngles.x >= 50f)
        {
            Debug.Log("down");
            LeftLegCenterOfGravity.SetBool("GreaterThan50", true);
            LeftLegCenterOfGravity.SetBool("LessThan-50", false);
        }
        else if (ItemTransform.transform.eulerAngles.x <= -50f)
        {
            Debug.Log("up");
            LeftLegCenterOfGravity.SetBool("LessThan-50", true);
            LeftLegCenterOfGravity.SetBool("GreaterThan50", false);
        }
    }
}
