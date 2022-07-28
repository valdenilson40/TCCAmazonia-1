using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visaocamera : MonoBehaviour
{
    public float cameraVelocidade = 15f;
    private Camera MainCamera;
    private float yCamera;
    void Start()
    {
        MainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate() {
        yCamera = MainCamera.transform.rotation.eulerAngles.y;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, yCamera, 0f), cameraVelocidade * Time.fixedDeltaTime);
    }
}
