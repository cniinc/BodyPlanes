using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PositronGames.BodyPlane
{
    
    public class AnatomyEnabler : MonoBehaviour
    {
        #region Properties

        [Tooltip("Find the object where the pivot is at the center of the person. That is the best object to create the planes")]
        
        public GameObject PlaneParent;

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
            
            createPlane(BodyPlaneType.saggital);
            createPlane(BodyPlaneType.coronal);
            createPlane(BodyPlaneType.transverse);
            
            
        }

        /// <summary>
        /// initializes and places a Medical plane according to anatomical placement
        /// </summary>
        /// <param name="plane"></param>
        private void createPlane(BodyPlaneType plane)
        {
            GameObject planeObject;

            switch (plane)
                {
                case BodyPlaneType.coronal:
                    { planeObject = Instantiate(Resources.Load("CoronalPlane"), PlaneParent.transform) as GameObject;
                      
                    }
                    break;
                case BodyPlaneType.saggital:
                    {
                        planeObject = Instantiate(Resources.Load("SaggitalPlane"), PlaneParent.transform) as GameObject;
                    }
                    break;

                case BodyPlaneType.transverse:
                    {
                        planeObject = Instantiate(Resources.Load("TransversePlane"), PlaneParent.transform) as GameObject;
                    }
                    break;
                default:
                    {
                        planeObject = new GameObject();
                        Debug.LogError("AnatomyEnabler for " + gameObject.name + "is trying to create a non-normal plane");
                       
                    }
                    break;
                }
            MedicalPlane newPlane = planeObject.GetComponent<MedicalPlane>() as MedicalPlane;
            if (newPlane == null)
                Debug.LogError("warning, medicalPlane script not found on the new plane. Check and make sure it's added to your plane");
            newPlane.Initialize();


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
