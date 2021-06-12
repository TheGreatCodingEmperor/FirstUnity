using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    public float speed = 0.1f;
    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        print("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position += new Vector3(-1 * speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Space) && this.gameObject.transform.position.y <= 1)
        {
            print(this.gameObject.transform.position.y);
            rigidbody2D.AddForce(Vector2.up * 20);
        }
        print("update");
    }
}
