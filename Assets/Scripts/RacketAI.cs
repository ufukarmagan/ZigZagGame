using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacketAI : Racket {
    
    public Transform ball;
    public float refDeger;

    public Vector2 dir;
    private void Start()
    {
          dir = ball.position;
    }

   // Vector2 oncekiPos;
  //  Vector2 mevcutPos;

    //float gecenSure;
    private void FixedUpdate()
    {
        //oncelikle top ile raket arasindaki fark (y) lazim
        // bu fark belli bir degerin ustunde ise topa dogru hamle yap. How?
        //eger top yukarda ise yukari git.
        //asagida ise asagiya gt.

        //if (Time.deltaTime > 0.05f)
        //{
        //    oncekiPos = mevcutPos;
        //}
        //else
        //{
        //    mevcutPos = ball.position;
        //}
        //dir =  mevcutPos- oncekiPos;
       


        float mesafe = Mathf.Abs(ball.position.y - transform.position.y);

        if (mesafe > refDeger /*&& dir.x > 0 */)
        {
            if (ball.position.y > transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;   
            }

            if (ball.position.y < transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;
            }
        }
    }
}
