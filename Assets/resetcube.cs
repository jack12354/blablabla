using UnityEngine;
using System.Collections;

public class resetcube : MonoBehaviour
{
    private Vector3 orig;
    private Quaternion origrot;
    // Use this for initialization
    void Start()
    {
        orig = transform.position;
        origrot = transform.rotation;
        GetComponent<Renderer>().material.color = new Color(Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f), Random.Range(0.2f, 0.8f), 0.15f);
       // var rand = Random.Range(0.0f, 1.0f);
       // foreach (var componentsInChild in GetComponentsInChildren<Renderer>())
       // {
       //     if (componentsInChild.transform != transform)
       //         componentsInChild.material.color = new Color(rand, rand, rand);
       // }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<Collider>().enabled = false;
            var speed = Input.GetKey(KeyCode.LeftShift) ? 0.01f : 0.15f;
            if (Input.GetKey(KeyCode.P)) speed = 1;
            transform.position = Vector3.Lerp(transform.position, orig, speed);
            transform.rotation = Quaternion.Lerp(transform.rotation, origrot, speed);
            GetComponent<Rigidbody>().velocity = Vector3.zero;//Vector3.Lerp(transform.position, Vector3.zero, 0.3f);
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;//Vector3.Lerp(transform.position, Vector3.Zero, 0.3f);

        }
        else
        {
            GetComponent<Collider>().enabled = true;
        }

    }
}
