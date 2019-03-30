using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private static List<GameObject> gameObjects = new List<GameObject>(3);

    [SerializeField, Header("Camera Movement"), 
        Tooltip("The speed which the camera is turned.")]
    private float _turnSpeed = 1.0f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void FixedUpdate () {

        this.transform.Rotate(0, Time.fixedDeltaTime * _turnSpeed, 0);
	}
}
