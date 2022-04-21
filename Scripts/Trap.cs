using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Trap : Hp
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
            hp--;
            Destroy(c);
        }
    }
}
