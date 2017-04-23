using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PositronGames.BodyPlane
{
    public class TransversePlane : MedicalPlane
    {
       private AnatomyEnabler.BodyPlaneType m_bodyPlaneType = AnatomyEnabler.BodyPlaneType.transverse;
       public AnatomyEnabler.BodyPlaneType bodyPlaneType { get { return m_bodyPlaneType; } }

        #region ClassMethods
        public override AnatomyEnabler.BodyPlaneRelation RelationToPlane(Vector3 objPos)
        {
            return AnatomyEnabler.BodyPlaneRelation.none;
        }

        protected override void alignBodyPlane()
        {
            transform.localRotation = Quaternion.FromToRotation(transform.up, transform.parent.up);

            
        }
        protected override void sizeBodyPlane(Collider _boundingBox)
        {
            transform.localScale = new Vector3(_boundingBox.bounds.size.x, .01f, _boundingBox.bounds.size.z);
        }



        #endregion
    }
}
