using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PositronGames.BodyPlane
{
    public class GameManager : MonoBehaviour
    {

        public Marker[] testMarkers;
        public AnatomyEnabler mainMan;

        // Use this for initialization
        void Start()
        {
            AssessMarkerPositions();
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.G))
                AssessMarkerPositions();
        }

        private void AssessMarkerPositions()
        {
            for (int i = 0; i < testMarkers.Length; i++)
            {
                
                AnatomyEnabler.BodyPlaneRelation[] relations = mainMan.GetAnatomicalRelation(testMarkers[i].transform.position); 
                testMarkers[i].updateRelations(relations[0], relations[1], relations[2]); 


            }
        }

        /*`
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