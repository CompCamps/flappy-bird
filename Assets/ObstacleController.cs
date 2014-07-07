using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

    public Vector3 velocity = new Vector3(-4, 0, 0);
    public float highestY = 3.0f;
    public float lowestY = -3.0f;

	void Start () {
        rigidbody.velocity = this.velocity;
        transform.position = new Vector3(transform.position.x,
            Random.Range(lowestY, highestY),
            transform.position.z);
	}

    void Update()
    {
        if (transform.position.x < -15.0f)
        {
            Destroy(gameObject);
        }
    }
}
