using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPitch : MonoBehaviour
{
    public float SpeedV = 10f;
    public float SpeedH = 10f;

    private float yaw = 0f;
    private float pitch = 0f;
    private float minPitch = -30f;
    private float maxPitch = 60f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotate();
    }
    void CameraRotate()
    {

        yaw += Input.GetAxis("Mouse X") * SpeedH;
        pitch -= Input.GetAxis("Mouse Y") * SpeedV;
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

    }
}
