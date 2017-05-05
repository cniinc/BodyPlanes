using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PositronGames.BodyPlane
{
    public class MedicalPlane : MonoBehaviour
    {
        

        #region UnityMethods
        private void Update()
        {

            
        }
        #endregion

        #region ClassMethods
        /// <summary>
        /// put point in, get relation as BodyPlaneRelation
        /// </summary>
        /// <param name="objPos"></param>
        /// <returns></returns>
        public virtual AnatomyEnabler.BodyPlaneRelation RelationToPlane(Vector3 objPos)
        {
            /*
             * Not working very well. Must fix for head 
            Vector3 heading = objPos - transform.localPosition;
            float dirNum = AngleDir(transform.forward, heading, transform.right);
            */

            return doNaming(1);
            
        }
        /// <summary>
        ///  WARNING: transform.position.up doesn't show the right direction. Not sure why but this is not usable until we do
        /// </summary>
        /// <param name="fwd"></param>
        /// <param name="targetDir"></param>
        /// <param name="up"></param>
        private void ShowDebugLines(Vector3 fwd, Vector3 targetDir, Vector3 up)
        {
            
            Debug.DrawLine(transform.position, fwd, Color.red);
            //Debug.DrawLine(transform.position, targetDir, Color.white);
            Debug.DrawLine(transform.position, up, Color.blue);

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
