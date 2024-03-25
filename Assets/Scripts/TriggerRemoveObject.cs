using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRemoveObject : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;

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
        targetObject.SetActive(false);
    }
}
