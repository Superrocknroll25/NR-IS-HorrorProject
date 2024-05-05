using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Animator m_LeftLegCenterOfGravity;
    public int RotationSpeed = 100;
    private Transform ItemTransform;
    /*public GameObject LeftLegCentOfGrav;*/
    // Start is called before the first frame update
    void Start()
    {
        ItemTransform = this.GetComponent<Transform>();
        m_LeftLegCenterOfGravity = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ItemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
        if (ItemTransform.transform.eulerAngles.x >= 50f)
        {
            Debug.Log("down");
            m_LeftLegCenterOfGravity.Play("LeftLegDown");
            /*m_LeftLegCenterOfGravity.SetBool("GreaterThan50", true);
            m_LeftLegCenterOfGravity.SetBool("LessThan-50", false);*/
        }
        else if (ItemTransform.transform.eulerAngles.x <= -50f)
        {
            m_LeftLegCenterOfGravity.Play("LeftLegUp");
            Debug.Log("up");
            /*m_LeftLegCenterOfGravity.SetBool("LessThan-50", true);
            m_LeftLegCenterOfGravity.SetBool("GreaterThan50", false);*/
        }
    }
}
