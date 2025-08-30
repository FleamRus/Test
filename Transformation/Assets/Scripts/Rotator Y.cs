using UnityEngine;

public class RotationY : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        int axisAngle = 0;
        transform.Rotate(axisAngle, _rotationSpeed * Time.deltaTime, axisAngle, Space.Self);
    }
}
