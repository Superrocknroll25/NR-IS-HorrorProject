using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Animator m_LeftLegCenterOfGravity;
    public int RotationSpeed = 100;
    private Transform ItemTransform;
    public bool goingUp;
    public bool goingDown;
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
        m_LeftLegCenterOfGravity.SetBool("SeeingPlayer", true);
        ItemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
        if (ItemTransform.transform.rotation.x >= 50)
        {
            Debug.Log("down");
            m_LeftLegCenterOfGravity.SetBool("GreaterThan50", true);
            m_LeftLegCenterOfGravity.SetBool("LessThan0", false);
        }
        else if (ItemTransform.transform.rotation.x <= 0)
        {
            Debug.Log("up");
            m_LeftLegCenterOfGravity.SetBool("LessThan0", true);
            m_LeftLegCenterOfGravity.SetBool("GreaterThan50", false);
        }
        else
        {
            if(goingUp == true)
            {
                m_LeftLegCenterOfGravity.SetBool("LessThan0", true);
                m_LeftLegCenterOfGravity.SetBool("GreaterThan50", false);
            }
            if(goingDown == false)
            {
                m_LeftLegCenterOfGravity.SetBool("GreaterThan50", true);
                m_LeftLegCenterOfGravity.SetBool("LessThan0", false);
            }
        }
    }
}
