using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Gold
{
    public class Gold : MonoBehaviour
    {
        protected internal int money;

        void Start()
        {

        }


        void Update()
        {

        }

        protected internal int Money()
        {
            money++;
            Debug.Log("Money = " + money);
            return money;
        }
    }
}
