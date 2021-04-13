using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float time;
    public Vector3 move;
    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //if (time == 60)
        Move();
    }

    private void Move()
    {
        transform.Translate(-move * moveSpeed * Time.deltaTime);
    }

}

