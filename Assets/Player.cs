using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vx = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        this.transform.position = new Vector3(transform.position.x + vx * x * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
