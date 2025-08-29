using UnityEngine;

public class UpSize : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float scale = Time.time * _speed;

        transform.localScale =  Vector3.one * scale;
    }
}

