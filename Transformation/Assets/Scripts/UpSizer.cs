using UnityEngine;

public class UpSizer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _initialScale = Vector3.one;

    private void Start()
    {
        transform.localScale = _initialScale;
    }

    private void Update()
    {
        int baseScale = 1;
        float scaleMultiplier = baseScale + (Time.time * _speed);
        Vector3 newScale = _initialScale * scaleMultiplier;

        transform.localScale = newScale;
    }
}
