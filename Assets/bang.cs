using UnityEngine;
using System.Collections;

public class bang : MonoBehaviour
{
    public float r;
    public float d;
    private int i = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (i == 0)
            Destroy(gameObject);
        i--;
    }

    void OnTriggerEnter(Collider other)
    {
        var ogo = other.gameObject;
        Debug.Log("boop");
        Rigidbody rb;
        if((rb = ogo.GetComponent<Rigidbody>()) != null)
        rb.AddExplosionForce(d, transform.position, r, 1.5f);
    }
}
