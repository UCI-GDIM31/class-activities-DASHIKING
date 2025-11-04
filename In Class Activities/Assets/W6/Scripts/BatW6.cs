using UnityEngine;

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private Transform _target;

    void Update()
    {
        if (_target != null)
        {
            // ?? MoveTowards ????????
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        }
    }

    // ????
    public void StartChasing()
    {
        enabled = true;
    }

    // ????
    public void StopChasing()
    {
        enabled = false;
    }
}

