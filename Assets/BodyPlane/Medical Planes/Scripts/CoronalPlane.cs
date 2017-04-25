using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PositronGames.BodyPlane
{

    public class CoronalPlane : MedicalPlane
    {

        private AnatomyEnabler.BodyPlaneType m_bodyPlaneType = AnatomyEnabler.BodyPlaneType.coronal;
        public AnatomyEnabler.BodyPlaneType bodyPlaneType { get { return m_bodyPlaneType; } }

        #region ClassMethods
        public override AnatomyEnabler.BodyPlaneRelation doNaming(int aboveOrBelow)
        {
            if (aboveOrBelow < 0)
                return AnatomyEnabler.BodyPlaneRelation.none;
            else return AnatomyEnabler.BodyPlaneRelation.none;
        }

        protected override void alignBodyPlane()
        {
            transform.localRotation = Quaternion.FromToRotation(transform.up, transform.parent.forward);
        }

        protected override void sizeBodyPlane(Collider _boundingBox)
        {
            transform.localScale = new Vector3(_boundingBox.bounds.size.z, .01f, _boundingBox.bounds.size.y);
        }
        #endregion
    }
    }
