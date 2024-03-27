using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToggleObjects : MonoBehaviour
{
    public List<GameObject> enable;
    public List<GameObject> disable;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in enable)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in disable)
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject obj in enable)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in disable)
        { 
            obj.SetActive(false); 
        }

    }
}
