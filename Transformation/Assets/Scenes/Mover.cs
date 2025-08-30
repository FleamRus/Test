using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update() 
    {
        var nextPosition = transform.position;
        nextPosition.z += _speed;
        transform.position = nextPosition;

        transform.Translate(_speed * Time.deltaTime * Vector3.forward);

        transform.LookAt(Vector3.up);
    }
}
