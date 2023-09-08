using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;

namespace BasicFacebookFeatures.ApplicationLogic
{
    public static class FormsFactory
    {
        public static Form CreateForm(eFormType i_FormType)
        {
            Form form = null;

            switch (i_FormType)
            {
                case eFormType.FormMain:
                    form = new FormMain();
                    break;
                case eFormType.FormRelationships:
                    form = new FormRelationships();
                    break;
                case eFormType.FormFriendsAnalytics:
                    form = new FormFriendsAnalytics();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_FormType), i_FormType, null);
            }

            return form;
        }

        public enum eFormType
        {
            FormMain,
            FormRelationships,
            FormFriendsAnalytics,
        }
    }
}