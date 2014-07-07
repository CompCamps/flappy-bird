using UnityEngine;
using System.Collections;

public class FlappyController : MonoBehaviour {

    public float force = 300.0f;

    private bool isDead = false;

    private bool debounce = true;

    void Start()
    {
        Physics.gravity = new Vector3(0, -15, 0);
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Jump") == 1 && !isDead && debounce)
        {
            debounce = false;
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * this.force);
        }
        if (Input.GetAxis("Jump") == 0)
            debounce = true;

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
