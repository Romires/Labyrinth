using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Hp : MonoBehaviour
    {
        protected internal int hp;
        void Start()
        {
            hp = 20;
            Debug.Log("hp = " + hp);
        }

        void Update()
        {
            if (hp >= 0)
            {
                Debug.Log("Looser");
            }
        }

        
    }
}