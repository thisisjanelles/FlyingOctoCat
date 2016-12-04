using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerObstacle : MonoBehaviour {

   private Rigidbody2D _rigidbody2D;


    // Use this for initialization
    void Start () {
       _rigidbody2D = GetComponent<Rigidbody2D>();
       _rigidbody2D.velocity = Vector2.left * 3;

    }

    // Update is called once per frame
    void Update () {
        


    }
}
