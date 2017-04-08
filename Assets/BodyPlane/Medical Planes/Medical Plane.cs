using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PositronGames.BodyPlane
{
    public class MedicalPlane : MonoBehaviour
    {

        #region ClassMethods
        public virtual AnatomyEnabler.BodyPlaneRelation RelationToPlane(Vector3 objPos)
        {
            return AnatomyEnabler.BodyPlaneRelation.none;
        }
        #endregion
    }
}
