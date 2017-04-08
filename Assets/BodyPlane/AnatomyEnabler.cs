using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PositronGames.BodyPlane
{
    
    public class AnatomyEnabler : MonoBehaviour
    {
        #region Properties

        public enum BodyPlaneType { none, saggital, coronal, transverse }
        public enum BodyPlaneRelation { none, ventral, dorsal, right, left, proximal, distal, anterior, posterior, superior, inferior, rostral, caudal }

        TransversePlane m_TransvPlane;
        SaggitalPlane m_SaggPlane;
        CoronalPlane m_CoroPlane;

        //
        #endregion



        #region ClassMethods

        private void Start()
        {
            /*
            createPlane(BodyPlaneType.saggital);
            createPlane(BodyPlaneType.coronal);
            createPlane(BodyPlaneType.transverse);
            */
            
        }

        /// <summary>
        /// initializes and places a Medical plane according to anatomical placement
        /// </summary>
        /// <param name="plane"></param>
        private void createPlane(BodyPlaneType plane)
        {
            switch (plane)
                {
                case BodyPlaneType.coronal:
                    { }
                    break;
                case BodyPlaneType.saggital:
                    { }
                    break;

                case BodyPlaneType.transverse:
                    { }
                    break;
                default:
                    Debug.LogError("AnatomyEnabler for " + gameObject.name + "is trying to create a non-normal plane");
                    break;

                }
        }

        public BodyPlaneRelation[] RelateObjectToPlane(GameObject obj)
        {
            BodyPlaneRelation[] relationships = new BodyPlaneRelation[3];

            relationships[0] = m_CoroPlane.RelationToPlane(obj.transform.position);
            relationships[1] = m_CoroPlane.RelationToPlane(obj.transform.position);
            relationships[2] = m_CoroPlane.RelationToPlane(obj.transform.position);
            return relationships;
        }

        #endregion
    }
}
