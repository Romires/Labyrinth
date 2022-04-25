using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Gold
{
    public class Gold : MonoBehaviour
    {
        protected internal int money = 0;

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
            Debug.Log("Для победы вам нужно собрать 10 монет");
        }
    }
}
