using UnityEngine;
using System.Collections;

public class FlappyController : MonoBehaviour {

    public float force = 300.0f;

    private bool isDead = false;

	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") == 1 && !isDead)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * this.force);
        }
        if (transform.position.y > 9.0)
            isDead = true;

        if(transform.position.y < -10.0)
            Application.LoadLevel(Application.loadedLevel);

	}

    void OnCollisionEnter(Collision collision)
    {
        isDead = true;
    }
}
