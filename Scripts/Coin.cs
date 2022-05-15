using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gold
{
    public class Coin: Gold
    {
        [SerializeField] GameObject c;

        void Start()
        {
            
        }

        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            Money();
            Destroy (c);
        }
    }
}
