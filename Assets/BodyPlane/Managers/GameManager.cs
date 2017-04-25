using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PositronGames.BodyPlane
{
    public class GameManager : MonoBehaviour
    {

        public GameObject[] testMarkers;
        public AnatomyEnabler mainMan;

        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < testMarkers.Length; i++)
            {
                print(mainMan.GetAnatomicalRelation(testMarkers[i].transform.position));
            }
        }

        void Update()
        {

        }

        /*
        /// <summary>
        /// Takes an object's vector3 and the frame of reference (the hand, body, etc. you compare to) and prints the relative location
        /// </summary>
        /// <param name="markerPos"></param>
        /// <param name="frame"></param>
        private string GetAnatomicalRelation(Vector3 point, AnatomyEnabler frame)
        {
            return "not filled in yet";
        }
        */
    }
}