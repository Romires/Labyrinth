﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Bonus : Hp
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
                PlusHp(hp);
            }
            catch
            {
                Debug.Log(" Ошибка ");
            }
            Destroy(c);
        }
    }
}
