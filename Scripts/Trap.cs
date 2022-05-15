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
            try
            {
                MinusHp(hp);
            }
            catch
            {
                Debug.Log(" Ошибка ");
            }
            Destroy(c);
        }
    }
}
