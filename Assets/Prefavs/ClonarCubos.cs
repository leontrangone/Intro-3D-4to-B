using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonarCubos : MonoBehaviour
{

    public GameObject cuboPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClonaCubos()
    {
        Instantiate(cuboPrefab);
    }
}
