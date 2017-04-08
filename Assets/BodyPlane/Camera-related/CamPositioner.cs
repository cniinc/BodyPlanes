using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PositronGames.BodyPlane {

    public class CamPositioner : MonoBehaviour
    {
        [SerializeField]
        private AnatomyEnabler.BodyPlaneRelation m_BodyAngle;
        [HideInInspector]
        public AnatomyEnabler.BodyPlaneRelation BodyAngle { get { return m_BodyAngle; } }

        //possible LookAt function?


    }
}
