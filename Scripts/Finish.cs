using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gold
{

    public class Finish : Gold
    {
        void Start()
        {

        }
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (money >= 10)
            {
                Debug.Log("Победа! :-) ");
            } else
            {
                Debug.Log("Для победы вам нужно собрать 10 монет");
            }
        }
    }
}
