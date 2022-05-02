using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit
{

    //public class Finish : Gold
    public class Finish : MonoBehaviour
    {
        void Start()
        {

        }
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            var end = Resources.Load<GameObject> ("End");
            var endInstance = GameObject.Instantiate (end).GetComponent<Unit>();
            endInstance.SetUnitPosition(new Vector2(438, 256));
        //    if (money >= 10)
        //    {
        //         Debug.Log("Победа! :-) ");
        //    } else
        //    {
        //        Debug.Log("Для победы вам нужно собрать 10 монет");
        //    }
        }
    }
}
