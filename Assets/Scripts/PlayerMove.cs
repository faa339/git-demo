using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 5f;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("Staring now!");
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
    }
}
