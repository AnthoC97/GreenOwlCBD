using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    //public float timeToLive = 5f;
    public float _speed = 0.65f;
   // private float timer;

    // Start is called before the first frame update
    void Start()
    {
        //if (timer > timeToLive)
        //{
        //    Debug.Log("OOK");
        //    Destroy(gameObject);
        //}

        //timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
