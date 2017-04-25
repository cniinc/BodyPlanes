using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PositronGames.BodyPlane
{
    public class MedicalPlane : MonoBehaviour
    {

        #region ClassMethods
        public AnatomyEnabler.BodyPlaneRelation RelationToPlane(Vector3 objPos)
        {
            Vector3 diff = objPos - transform.localPosition;

            return AnatomyEnabler.BodyPlaneRelation.none;
            
            
            //AnatomyEnabler.BodyPlaneRelation relation;
        }

        public virtual AnatomyEnabler.BodyPlaneRelation doNaming(int aboveOrBelow)
        {
            Debug.LogError("Warning, this is using the parent MedicalPlane");
            return AnatomyEnabler.BodyPlaneRelation.none;
        }

        public virtual void Initialize(Collider VisualBounds)
        {
            transform.localPosition = Vector3.zero;
            alignBodyPlane();
            sizeBodyPlane(VisualBounds);
        }

        protected virtual void alignBodyPlane()
        {
            Debug.LogError("BodyPlane alignment using the parent MedicalPlane function");
        }

        protected virtual void sizeBodyPlane(Collider _boundingBox)
        { }
        #endregion
    }
}
