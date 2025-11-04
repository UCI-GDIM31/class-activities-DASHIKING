using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private Transform _target;


    void Update()
    {
        
        if (_target != null)
        {
            
            Vector3 direction = (_target.position - transform.position).normalized;

            
            transform.position += direction * _speed * Time.deltaTime;
        }
    }

    
    public void StartChasing()
    {
        gameObject.SetActive(true);
    }

    
    public void StopChasing()
    {
        gameObject.SetActive(false);
    }
}

