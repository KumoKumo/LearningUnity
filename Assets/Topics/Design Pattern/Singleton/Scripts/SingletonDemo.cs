using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LazyIntantiateSingleton<Player>.Instance().SayHi();
    }

}
