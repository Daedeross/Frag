using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public GameObject Orbit;
    public GameObject Tilt;
    public float OrbitSpeed = 1f;
    public float TiltSpeed = 1f;

    // Use this for initialization
    void Start () {
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetButton("Secondary"))
        {
            float dy = TiltSpeed * Input.GetAxis("Mouse Y");

            if (Input.GetButton("Primary"))
            {
                transform.Translate(0, 0, dy);
                var pos = transform.position;
                if (pos.z > 0)
                {
                    pos.z = 0;                      
                    transform.position = pos;
                }
            }
            else
            {
                float dx = OrbitSpeed * Input.GetAxis("Mouse X");
                Orbit.transform.Rotate(0, dx, 0);
                Tilt.transform.Rotate(-dy*4, 0, 0);
            }
        }

        Vector3 translate = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Orbit.transform.Translate(translate);
    }
}
