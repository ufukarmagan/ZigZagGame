using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacketMover : Racket {
    public string movementAxis;
  
    private void FixedUpdate()
    {
        float vertical = Input.GetAxisRaw(movementAxis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertical) * moveSpeed;
    }
}
