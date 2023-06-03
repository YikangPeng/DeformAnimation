using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{

    public Animator _animator;
    private bool isplay = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.name =="Switch") && (!isplay))
        {
            _animator.SetTrigger("play");
        }
    }
}
