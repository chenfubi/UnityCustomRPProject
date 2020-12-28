using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    Transform sphere;

    [SerializeField]
    Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        for(int z = 0, i = 0; z < 10; ++z) {
            for(int x = 0; x<10 && i<76; ++x, ++i) {
                Transform t = Instantiate<Transform>(sphere);
                t.position = new Vector3(x, 0, z);
                MeshRenderer mr = t.gameObject.GetComponent<MeshRenderer>();
                mr.material = materials[Random.Range(0, materials.Length)];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
