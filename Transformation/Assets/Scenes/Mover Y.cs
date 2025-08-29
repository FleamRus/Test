using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverY : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        transform.LookAt(Vector3.up);
    }
}
