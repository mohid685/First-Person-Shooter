using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ControlScript : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
             GameObject g= Instantiate(enemy, new Vector3(Random.Range(-200, 200), 10, Random.Range(-200, 200)), Quaternion.identity);
            g.GetComponent<AICharacterControl>().target = player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
