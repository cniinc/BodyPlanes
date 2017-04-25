using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace PositronGames.BodyPlane
{
    public class Marker : MonoBehaviour
    {
        private AnatomyEnabler.BodyPlaneRelation m_coronalRelation;
        public AnatomyEnabler.BodyPlaneRelation coronalRelation { get { return m_coronalRelation; } }
        private AnatomyEnabler.BodyPlaneRelation m_saggitalRelation;
        public AnatomyEnabler.BodyPlaneRelation saggitalRelation { get { return m_saggitalRelation; } }
        private AnatomyEnabler.BodyPlaneRelation m_transverseRelation;
        public AnatomyEnabler.BodyPlaneRelation transverseRelation { get { return m_transverseRelation; } }

        [SerializeField] private Text uiText;

        #region UnityMethods
       
        #endregion

        #region ClassMethods
        public void updateRelations(AnatomyEnabler.BodyPlaneRelation coronalRelation, AnatomyEnabler.BodyPlaneRelation saggitalRelation, AnatomyEnabler.BodyPlaneRelation transverseRelation)
        {
            m_coronalRelation = coronalRelation;
            m_saggitalRelation = saggitalRelation;
            m_transverseRelation = transverseRelation;

            updateText();
        }

        private void updateText()
        {
            uiText.text = m_coronalRelation + ", " + m_saggitalRelation + ", " + m_transverseRelation;
        }
        #endregion
    }
}