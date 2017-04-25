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
            Vector3 heading = objPos - transform.localPosition;
            float dirNum = AngleDir(transform.forward, heading, transform.right);

            return doNaming((int)dirNum);
            
            //AnatomyEnabler.BodyPlaneRelation relation;
        }

        float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
        {
            Vector3 perp = Vector3.Cross(fwd, targetDir);
            float dir = Vector3.Dot(perp, up);

            if (dir > 0f)
            {
                return 1f;
            }
            else if (dir < 0f)
            {
                return -1f;
            }
            else
            {
                return 0f;
            }
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
