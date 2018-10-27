using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private Transform transform;
    private float angle = 0;

	// Use this for initialization
	void Start () {
        transform = GetComponent<Transform>();
	}

    public void rotate()
    {
        angle += 90f;
        transform.Rotate(new Vector3(angle, -180, 0));
        Debug.Log(transform.eulerAngles);

    }
}
