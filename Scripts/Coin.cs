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
            try
            {
                Money();
            }
            catch
            {
                Debug.Log(" Ошибка ");
            }

            
            Destroy (c);
        }
    }
}
