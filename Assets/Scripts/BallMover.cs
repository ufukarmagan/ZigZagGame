using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour {
    public float moveSpeed=10;
    public GameObject solRaket;
    public GameObject sagRaket;
    public AudioSource audiSource;

	// Use this for initialization
	void Start () {
       
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        audiSource.Play();
        if (other.gameObject.name == "solRaket")
        {
            float xVal = 1;  // sol rakette top donuste +1 yonunde seker.
            GeriDonusYonHesapla(other, xVal);
        }

        if (other.gameObject.name == "sagRaket")
        {
            float xVal = -1; // sag rakette top donuste -1 yonunde seker.
            GeriDonusYonHesapla(other, xVal);
        }


        if (other.gameObject.name == "solDuvar")
        {
            //sag raket skor yapsin
            sagRaket.GetComponent<Racket>().SkorYap();
        }


        if (other.gameObject.name == "sagDuvar")
        {
            //sol raket skor yapsin
            solRaket.GetComponent<Racket>().SkorYap();
        }
    }

    private void GeriDonusYonHesapla(Collision2D other, float xVal)
    {
        float yFark = transform.position.y - other.transform.position.y;  // top y  pos - raket y pos.
        float raketBoyu = other.collider.bounds.size.y;
        float yYonDegeri = yFark / raketBoyu;
        GetComponent<Rigidbody2D>().velocity = new Vector2(xVal, yYonDegeri) * moveSpeed;
    }

    private void OnCollisionExit(Collision other)
    {

        if (other.gameObject.name == "solRaket")
        {
            other.rigidbody.transform.position = new Vector2(-9.83f, -2.701317f);
        }

        if (other.gameObject.name == "sagRaket")
        {
            other.rigidbody.transform.position = new Vector2(9.83f, -2.701317f);
        }
     
    }
}
