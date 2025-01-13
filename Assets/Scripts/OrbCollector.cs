using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCollector : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<ICollectable>(out ICollectable icoll))
        {
            {
                icoll.OnCollected();
                _animator.SetTrigger("Collected");
                _animator.SetLayerWeight(1, 1);
                GetComponent<PlayerController>().canMove = false;
            }
        }
    }
}
