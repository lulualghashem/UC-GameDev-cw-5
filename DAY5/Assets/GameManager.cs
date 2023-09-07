using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Maxpos;
    public Transform Midpos;
    public Transform Minpos;
    public GameObject Enemy;
    public float Delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, Delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        int Randompos = Random.Range(1, 4);
        if (Randompos == 1)
        {
            Instantiate(Enemy, Maxpos);
        }
        else if (Randompos == 2)
        {
            Instantiate(Enemy, Midpos);
        }
        else if(Randompos == 3)
        {
            Instantiate(Enemy, Minpos);
        }
    }
}
