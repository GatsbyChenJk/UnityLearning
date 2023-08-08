using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllor : MonoBehaviour
{

    public Transform target = null; // �����Transform���
    public float rotationSpeed = 1f; // �������ת�ٶ�
    //public float moveSpeed = 0.1f;
    //public RectTransform CanvasTrans = null;
    //public Vector3 Distance = new Vector3(0,0,0);

    private float mouseX; // �����ˮƽ�����ϵ��ƶ�����
    private float mouseY; // �������ֱ�����ϵ��ƶ�����

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
            mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        }

        if (target)
        {
            // �����������λ�ú���ת
            Vector3 offset = Quaternion.Euler(mouseY, mouseX, 0) * new Vector3(0, 0, -10);
            transform.position = target.position + offset ;
            transform.LookAt(target);
        }
    }
}
