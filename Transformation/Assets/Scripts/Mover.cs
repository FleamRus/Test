using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _moveDirection = Vector3.forward;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _moveDirection, Space.Self);
    }
}
