using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject TestPlayer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            TestPlayer.transform.position = new Vector3(TestPlayer.transform.position.x + speed, TestPlayer.transform.position.y, TestPlayer.transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            TestPlayer.transform.position = new Vector3(TestPlayer.transform.position.x - speed, TestPlayer.transform.position.y, TestPlayer.transform.position.z);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            TestPlayer.transform.position = new Vector3(TestPlayer.transform.position.x, TestPlayer.transform.position.y, TestPlayer.transform.position.z + speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            TestPlayer.transform.position = new Vector3(TestPlayer.transform.position.x, TestPlayer.transform.position.y, TestPlayer.transform.position.z - speed);
        }
    }
}
