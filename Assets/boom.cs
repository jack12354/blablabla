using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class boom : MonoBehaviour
{
    public GameObject dur;
    private TextMesh words;
    private float ddt = 100.0f;
    public float ddr = 5.0f;
    // Use this for initialization
    private void Start()
    {
        words = GetComponentInChildren<TextMesh>();
        newtext();
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            dur.transform.position = hit.point;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var go = (GameObject)Instantiate(Resources.Load("Explosion"), dur.transform.position, dur.transform.rotation);
            go.transform.localScale = new Vector3(ddr, ddr, ddr);
            var b = go.GetComponent<bang>();
            b.d = ddt;
            b.r = ddr;
            Debug.Log("bang");
        }
        if (Input.GetKeyUp(KeyCode.Equals))
        {
            ddt += 10f;
            newtext();
        }
        if (Input.GetKeyUp(KeyCode.Minus))
        {
            ddt -= 10f;
            newtext();
        }
        if (Input.GetKeyUp(KeyCode.RightBracket))
        {
            ddr += 1f;
            newtext();
        }
        if (Input.GetKeyUp(KeyCode.LeftBracket))
        {
            ddr -= 1f;
            newtext();
        }
    }

    private void newtext()
    {
        words.text = "f:" + ddt + "\nr:" + ddr;
    }
}