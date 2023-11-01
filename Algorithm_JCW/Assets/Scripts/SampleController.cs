using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleController : MonoBehaviour
{   
    void Start()
    {
        Singleton.Instance.InscreaseScore(10);
        GameManager.instance.InscreaseScore(15);
        //Start 함수가 호출될때 Instance에 접근해서 10점을 추가 
    }
}
