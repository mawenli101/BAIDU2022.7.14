using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform player;
    private float mouseX, mouseY; //获取鼠标移动的值
    public float mouseSensitivity; //鼠标灵敏度
    public float xRotation;

    private void Start () {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update () {
        mouseX = Input.GetAxis ("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis ("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp (xRotation, -70f, 70f);

        player.Rotate (Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler (xRotation, 0, 0);

    }
}