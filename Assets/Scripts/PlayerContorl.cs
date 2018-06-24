using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorl : MonoBehaviour {

    public GameObject HitPre;
    public GameObject BombPre;

    private Rigidbody rBody;

    public int hp = 3;

	void Start () {
        rBody = GetComponent<Rigidbody>();
	}

	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        if(dir != Vector3.zero)
        {
            rBody.velocity = dir * 2;
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Wall")
        {
            hp--;
            if(hp <= 0)
            {
                Instantiate(BombPre, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }else
            {
                Instantiate(HitPre, collision.contacts[0].point, Quaternion.identity);
            }
        }
    }
}
