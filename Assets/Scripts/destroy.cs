using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destloi : MonoBehaviour
{
    //��O�ɏo���I�u�W�F�N�g����������������

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject .tag == "Candy" )
        {
            Destroy(other.gameObject);
        }
    }

}
